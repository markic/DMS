using AutoMapper;
using DMS.DomainModel;
using DMS.DTO;
using DMS.Exceptions;
using DMS.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Transactions;

namespace DMS.Services
{
	public class DocumentsBusinessService : BusinessServiceBase
	{
		/// <summary>
		/// Loads all document for current user.
		/// </summary>
		/// <param name="userDto">The user dto.</param>
		/// <returns></returns>
		public IEnumerable<DocumentDTO> LoadUserDocuments(UserDTO userDto)
		{
			Expression<Func<tDocument, bool>> restriction = x => x.IsValid;

			if (userDto.AuthorizationRole == AuthorizationRoleCodes.Operator)
			{
				restriction = ExpressionUtils.AndOperation(restriction, u => u.tUserDocuments.Select(x => x.UserId).Contains(userDto.Id));
			}
			BeginTransaction();
			var result = Mapper.Map<IEnumerable<DocumentDTO>>(Context.tDocuments.Where(restriction));
			EndTransaction();
			return result;
		}

		/// <summary>
		/// Loads documents that are matched by criteria from filter.
		/// </summary>
		/// <param name="userDto">The user dto.</param>
		/// <returns></returns>
		public IEnumerable<DocumentDTO> LoadUserDocuments(DocumentFilterDTO filter)
		{
			Expression<Func<tDocument, bool>> restriction = x => x.IsValid;

			if (filter.LoggedUser.AuthorizationRole == AuthorizationRoleCodes.Operator)
			{
				restriction = ExpressionUtils.AndOperation(restriction, u => u.tUserDocuments.Select(x => x.UserId).Contains(filter.LoggedUser.Id));
			}

			if (!String.IsNullOrEmpty(filter.Title))
			{
				restriction = ExpressionUtils.AndOperation(restriction, u => u.Title.Contains(filter.Title));
			}

			if (!String.IsNullOrEmpty(filter.Keywords))
			{
				string[] keywords = filter.Keywords.Split(' ', ',');
				Expression<Func<tDocument, bool>> wordRestriciton = x => false; // false || kw1 || kw2

				foreach (string word in keywords)
				{
					wordRestriciton = ExpressionUtils.OrOperation(wordRestriciton, x => x.tKeywords.Select(k => k.Name).Contains(word));
				}
				restriction = ExpressionUtils.AndOperation(restriction, wordRestriciton);
			}
			if (!String.IsNullOrEmpty(filter.Extension))
			{
				restriction = ExpressionUtils.AndOperation(restriction, u => u.Extension.Contains(filter.Extension));
			}
			if (filter.DateFrom.HasValue)
			{
				DateTime date1 = filter.DateFrom.Value.Date;
				restriction = ExpressionUtils.AndOperation(restriction, u => u.CreatedAt >= date1);
			}
			if (filter.DateTo.HasValue)
			{
				DateTime date2 = filter.DateTo.Value.AddDays(1).Date;
				restriction = ExpressionUtils.AndOperation(restriction, u => u.CreatedAt <= date2);
			}
			if (filter.OnlyActive)
			{
				restriction = ExpressionUtils.AndOperation(restriction, u => !u.IsArchived);
			}
			if (filter.OnlyArchived)
			{
				restriction = ExpressionUtils.AndOperation(restriction, u => u.IsArchived);
			}
			if (!String.IsNullOrEmpty(filter.UserName))
			{
				restriction = ExpressionUtils.AndOperation(restriction, u => u.tUserDocuments.Select(x => x.tUser.UserName).Contains(filter.UserName));
			}

			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				return Mapper.Map<IEnumerable<DocumentDTO>>(context.tDocuments.Where(restriction).OrderBy(u => u.CreatedAt));
			}
		}

		/// <summary>
		/// Sets IsValid property to false for document specified by id.
		/// </summary>
		/// <param name="id">The id of a user.</param>
		public void DeleteDocument(int id)
		{
			BeginTransaction();
			tDocument result = Context.tDocuments.Find(id);
			if (result == null) return;
			result.IsValid = false;
			Context.SaveChanges();
			EndTransaction();
		}

		/// <summary>
		/// Loads list of document shares for specified user. Document owner is not loaded. Administrators are not loaded.
		/// </summary>
		/// <param name="documentId">The document id.</param>
		/// <returns>List of <see cref="DocumentShareDTO"/></returns>
		public IEnumerable<DocumentShareDTO> LoadDocumentsShare(int documentId)
		{
			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				return context.tUserDocuments.Where(u => u.DocumentId == documentId && u.DocumentAccessRightId != (int) DocumentAccessRightCodes.Owner && u.tUser.AuthorizationRoleId != (int) AuthorizationRoleCodes.Administrator)
					.Select(u => new DocumentShareDTO(){
						AccessRight = (DocumentAccessRightCodes) u.DocumentAccessRightId,
						UserName = u.tUser.UserName,
						UserId = u.UserId
					}).ToList();
			}
		}

		/// <summary>
		/// Adds new document to system.
		/// </summary>
		/// <param name="documentDto">The document</param>
		/// <param name="ownerId">The owner id = logged user id.</param>
		/// <returns></returns>
		public DocumentDTO SaveNewDocument(DocumentDTO documentDto, int ownerId)
		{
			if (documentDto == null) throw new ArgumentNullException("documentDto");
			
			documentDto.CreatedAt = DateTime.Now;
			documentDto.IsArchived = false;
			documentDto.IsLocked = false;
			documentDto.IsValid = true;

			tDocument result = Mapper.Map<tDocument>(documentDto);
			result.Version = 1;
			result.Guid = Guid.NewGuid();
			result.Extension = result.Extension.TrimStart('.');

			result.tKeywords = Mapper.Map<List<tKeyword>>(documentDto.Keywords.ToList());

			foreach (DocumentShareDTO share in documentDto.DocumentShares)
			{
				tUserDocument ud = new tUserDocument();
				ud.IsReading = false;
				ud.IsWriting = false;
				ud.UserId = share.UserId;
				ud.DocumentId = documentDto.Id;
				ud.DocumentAccessRightId = (int) share.AccessRight;

				result.tUserDocuments.Add(ud);
			}

			tUserDocument owner = new tUserDocument(){
				IsReading = false,
				IsWriting = false,
				DocumentAccessRightId = (int) DocumentAccessRightCodes.Owner,
				UserId = ownerId
			};

			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				result = context.tDocuments.Add(result);
				context.SaveChanges();

				owner.DocumentId = result.Id;
				result.tUserDocuments.Add(owner);
				context.SaveChanges();
			}

			AddAdministratorsToDocument(result.Id, ownerId);
			documentDto.Id = result.Id;
			return documentDto;
		}

		/// <summary>
		/// Updates document title, keywords and sharing with users.
		/// </summary>
		/// <param name="documentDto">The document dto.</param>
		/// <param name="loggedUserId">The logged user id.</param>
		public void UpdateDocumentData(DocumentDTO documentDto, long loggedUserId)
		{
			if (documentDto == null) throw new ArgumentNullException("documentDto");

			// operators, not owner, not logged user
			Expression<Func<tUserDocument, bool>> oldShareRestrictions = x => x.DocumentId == documentDto.Id 
				&& x.DocumentAccessRightId != (int)DocumentAccessRightCodes.Owner && x.UserId != loggedUserId && x.tUser.AuthorizationRoleId == (int) AuthorizationRoleCodes.Operator;

			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				tDocument document = context.tDocuments.Find(documentDto.Id);
				document.tKeywords.Clear();
				document.tKeywords = Mapper.Map<List<tKeyword>>(documentDto.Keywords.ToList());

				document.LastModifiedAt = DateTime.Now;
				document.Version++;
				document.Title = documentDto.Title;

				IEnumerable<tUserDocument> oldShared = context.tUserDocuments.Where(oldShareRestrictions);
				foreach (tUserDocument ud in oldShared)
				{
					context.tUserDocuments.Remove(ud);
				}

				foreach (DocumentShareDTO share in documentDto.DocumentShares)
				{
					tUserDocument ud = new tUserDocument();
					ud.IsReading = false;
					ud.IsWriting = false;
					ud.UserId = share.UserId;
					ud.DocumentId = documentDto.Id;
					ud.DocumentAccessRightId = (int)share.AccessRight;

					document.tUserDocuments.Add(ud);
				}

				context.SaveChanges();
			}
		}

		/// <summary>
		/// Toggles value of archived flag for specified document.
		/// </summary>
		/// <param name="documentDto">The document dto.</param>
		/// <returns>The modified document dto.</returns>
		public DocumentDTO ToggleArchivedFlag(DocumentDTO documentDto)
		{
			documentDto.IsArchived = !documentDto.IsArchived;
			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				tDocument document = context.tDocuments.Find(documentDto.Id);
				Mapper.Map(documentDto, document);
				document.Version++;
				context.SaveChanges();
				return documentDto;
			}
		}

		/// <summary>
		/// Gives modify access right to all administrators of system except owner, to the document.
		/// </summary>
		/// <param name="documentId">The document id</param>
		private void AddAdministratorsToDocument(int documentId, int ownerId)
		{
			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				IEnumerable<tUser> users = context.tUsers.Where(u => u.AuthorizationRoleId == (int)AuthorizationRoleCodes.Administrator && u.Id != ownerId);
				foreach (tUser user in users)
				{
					tUserDocument ud = new tUserDocument()
					{
						DocumentId = documentId,
						IsReading = false,
						IsWriting = false,
						DocumentAccessRightId = (int) DocumentAccessRightCodes.Modify,
 						UserId = user.Id
					};
					
					context.tUserDocuments.Add(ud);
				}
				context.SaveChanges();
			}
		}

		#region Reading / Writing

		/// <summary>
		/// Check if user is currently writing to last version of document.
		/// </summary>
		/// <param name="userId">The user id.</param>
		/// <param name="documentId">The document id.</param>
		/// <returns></returns>
		public bool IsUserWritingToDocument(int userId, int documentId)
		{
			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				tUserDocument ud = context.tUserDocuments.Where(u => u.UserId == userId && u.DocumentId == documentId).SingleOrDefault();
				if (ud == null) throw new AuthorizationException();
				return ud.IsWriting;
			}
		}

		/// <summary>
		/// Check if user is currently reading from last version of document.
		/// </summary>
		/// <param name="userId">The user id.</param>
		/// <param name="documentId">The document id.</param>
		/// <returns></returns>
		public bool IsUserReadingFromDocument(int userId, int documentId)
		{
			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				tUserDocument ud = context.tUserDocuments.Where(u => u.UserId == userId && u.DocumentId == documentId).SingleOrDefault();
				if (ud == null) throw new AuthorizationException();
				return ud.IsReading;
			}
		}

		/// <summary>
		/// Returns true if user has write access right for document.
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="documentId"></param>
		/// <returns></returns>
		public bool CheckIfUserHasWriteAccess(int userId, int documentId)
		{
			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				tUser user = context.tUsers.Find(userId);
				if (user.AuthorizationRoleId == (int)AuthorizationRoleCodes.Administrator) return true;

				tUserDocument ud = context.tUserDocuments.Where(u => u.UserId == userId && u.DocumentId == documentId).SingleOrDefault();
				if (ud == null) return false;
				if (ud.DocumentAccessRightId == (int)DocumentAccessRightCodes.Owner) return true;
				if (ud.DocumentAccessRightId == (int)DocumentAccessRightCodes.Modify) return true;
				return false;
			}
		}

		/// <summary>
		/// Closes file without saving changes or creating new version.
		/// </summary>
		/// <param name="documentId">The document id.</param>
		/// <param name="userId">The user id.</param>
		public void CloseDocument(int documentId, int userId)
		{
			BeginTransaction();

			tUserDocument ud =  Context.tUserDocuments.Where(u => u.DocumentId == documentId && u.UserId == userId).Single();
			tDocument document = Context.tDocuments.Find(documentId);
			document.IsLocked = false;
			ud.IsReading = false;
			ud.IsWriting = false;
			Context.SaveChanges();

			EndTransaction();
		}

		/// <summary>
		/// Opens document for reading for current user if document is not locked.
		/// </summary>
		/// <param name="documentId">The document id.</param>
		/// <param name="loggedUserId">The logged user id.</param>
		/// <returns>Returns true if document is opened.</returns>
		public bool TryOpenDocumentForReading(int documentId, int loggedUserId)
		{
			using (TransactionScope scope = new TransactionScope())
			{
				using (DMSDataBaseEntities context = new DMSDataBaseEntities())
				{
					tDocument document = context.tDocuments.Find(documentId);
					if (document.IsLocked)
					{
						scope.Complete();
						return false;
					}

					tUserDocument ud = context.tUserDocuments.Where(u => u.DocumentId == documentId && u.UserId == loggedUserId).Single();
					ud.IsReading = true;
					context.SaveChanges();

					scope.Complete();
					return true;
				}
			}
		}

		/// <summary>
		/// Opens document for writing for current user if document is not locked and no one currently reads it.
		/// </summary>
		/// <param name="documentId">The document id.</param>
		/// <param name="loggedUserId">The logged user id.</param>
		/// <returns></returns>
		public bool TryOpenDocumentForWriting(int documentId, int loggedUserId)
		{
			using (TransactionScope scope = new TransactionScope())
			{
				using (DMSDataBaseEntities context = new DMSDataBaseEntities())
				{
					tDocument document = context.tDocuments.Find(documentId);
					if (document.IsLocked)
					{
						scope.Complete();
						return false;
					}
					int readers = context.tUserDocuments.Where(u => u.DocumentId == documentId && u.IsReading).Count();
					if (readers > 0)
					{
						scope.Complete();
						return false;
					}

					tUserDocument ud = context.tUserDocuments.Where(u => u.DocumentId == documentId && u.UserId == loggedUserId).Single();
					ud.IsWriting = true;
					document.IsLocked = true;
					context.SaveChanges();
					scope.Complete();
					return true;
				}
			}
		}

		#endregion Reading / Writing

		#region Versions

		/// <summary>
		/// Loads all versions for specified document except the last one.
		/// </summary>
		/// <param name="documentId">The document id.</param>
		/// <returns>List of <see cref="DocumentVErsionDTO"/></returns>
		public IEnumerable<DocumentVersionDTO> LoadDocumentVersions(int documentId)
		{
			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				IQueryable<tDocumentVersion> versions = context.tDocumentVersions.Where(u => u.DocumentId == documentId && u.tDocument.IsValid).OrderByDescending(u => u.CreatedAt);
				if (versions == null || versions.Count() < 2) return null;
				versions = versions.Skip(1);
				return Mapper.Map<IEnumerable<DocumentVersionDTO>>(versions);
			}
		}

		/// <summary>
		/// Adds new document version to document, which takes next hierarchy id.
		/// </summary>
		/// <param name="document">The document id.</param>
		/// <returns>Returns the filepath of the new document version.</returns>
		public string AddNewDocumentVersion(DocumentDTO document)
		{
			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				tDocumentVersion lastVersion = context.tDocumentVersions.Where(u => u.DocumentId == document.Id).OrderByDescending(u => u.HierarchyId).FirstOrDefault();

				tDocumentVersion documentVersion = new tDocumentVersion();
				documentVersion.Guid = Guid.NewGuid();
				documentVersion.CreatedAt = DateTime.Now;
				documentVersion.HierarchyId = (lastVersion == null) ? 1 : lastVersion.HierarchyId + 1;
				documentVersion.DocumentId = document.Id;
				documentVersion.Version = 1;
				documentVersion.FilePath = documentVersion.Guid + document.Extension;
				context.tDocumentVersions.Add(documentVersion);
				context.SaveChanges();
				return documentVersion.FilePath;
			}
		}

		/// <summary>
		/// Loads filepath of last version of specified document.
		/// </summary>
		/// <param name="documentId"></param>
		/// <returns></returns>
		public string GetLastDocumentVersionFilePath(int documentId)
		{
			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				return context.tDocumentVersions.Where(u => u.DocumentId == documentId).OrderByDescending(u => u.HierarchyId).First().FilePath;
			}
		}

		#endregion Versions

		#region Comments

		/// <summary>
		/// Loads all coments for document version
		/// </summary>
		/// <param name="versionId">The document version id</param>
		/// <returns></returns>
		public List<CommentDTO> LoadDocumentComments(int versionId)
		{
			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				IQueryable<tComment> comments = context.tComments.Where(u => u.tDocumentVersion.Id == versionId).OrderByDescending(u => u.CreatedAt);
				return Mapper.Map<List<CommentDTO>>(comments.ToList());
			}
		}

		/// <summary>
		/// Saves the new comment.
		/// </summary>
		/// <param name="commentDto">The comment dto.</param>
		/// <returns></returns>
		public CommentDTO SaveNewComment(CommentDTO commentDto)
		{
			commentDto.CreatedAt = DateTime.Now;
			tComment comment = Mapper.Map<tComment>(commentDto);
			
			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				context.tComments.Add(comment);
				context.SaveChanges();
			}

			return commentDto;
		}

		#endregion Comments

		#region Keywords

		/// <summary>
		/// Loads list of keywords for specified document.
		/// </summary>
		/// <param name="documentId">The document id</param>
		/// <returns></returns>
		public IEnumerable<string> LoadDocumentKeywords(int documentId)
		{
			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				return context.tKeywords.Where(u => u.tDocuments.Select(x => x.Id).Contains(documentId))
					.Select(u => u.Name).ToList();
			}
		}

		#endregion Keywords
	}
}
