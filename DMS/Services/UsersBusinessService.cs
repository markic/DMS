using DMS.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DMS.DTO;
using DMS.Exceptions;
using System.Linq.Expressions;
using DMS.Utils;

namespace DMS.Services
{
	public class UsersBusinessService : BusinessServiceBase
	{
		/// <summary>
		/// Returns list of user DTO objects that are valid.
		/// </summary>
		/// <returns></returns>
		public IEnumerable<UserDTO> LoadUsers()
		{
			BeginTransaction();
			IEnumerable<UserDTO> result = Mapper.Map<IEnumerable<UserDTO>>(Context.tUsers.Where(u => u.IsValid));
			EndTransaction();
			return result;
		}

		/// <summary>
		/// Returns list of user DTO objects that are valid and match user filter.
		/// </summary>
		/// <param name="filter"></param>
		/// <returns></returns>
		public IEnumerable<UserDTO> LoadFilteredUsers(UserFilterDTO filter)
		{
			Expression<Func<tUser, bool>> restriction = x => x.IsValid;

			if (!String.IsNullOrEmpty(filter.UserName))
			{
				restriction = ExpressionUtils.AndOperation(restriction, x => x.UserName.Contains(filter.UserName));
			}
			if (!String.IsNullOrEmpty(filter.FirstName))
			{
				restriction = ExpressionUtils.AndOperation(restriction, x => x.FirstName.Contains(filter.FirstName));
			}
			if (!String.IsNullOrEmpty(filter.LastName))
			{
				restriction = ExpressionUtils.AndOperation(restriction, x => x.FirstName.Contains(filter.LastName));
			}

			BeginTransaction();
			IEnumerable<UserDTO>  result = Mapper.Map<IEnumerable<UserDTO>>(Context.tUsers.Where(restriction));
			EndTransaction();
			return result;
		}

		/// <summary>
		/// Returns user dto specified by user name.
		/// </summary>
		/// <param name="userName">The name of the user.</param>
		/// <returns></returns>
		public UserDTO LoadUserByName(string userName)
		{
			BeginTransaction();
			tUser result = Context.tUsers.Where(u => u.UserName.Equals(userName) && u.IsValid).SingleOrDefault();
			EndTransaction();
			if (result == null)
			{
				throw new UserNotFoundException();
			}
			return Mapper.Map<UserDTO>(result);
		}

		/// <summary>
		/// Returns user dto specified by id.
		/// </summary>
		/// <param name="id">The id of the user.</param>
		/// <returns></returns>
		public UserDTO LoadUserById(int id)
		{
			BeginTransaction();
			tUser result = Context.tUsers.Find(id);
			EndTransaction();
			if (result == null)
			{
				throw new UserNotFoundException();
			}
			return Mapper.Map<UserDTO>(result);
		}

		/// <summary>
		/// Returns true if user with this unique username already exists. 
		/// </summary>
		/// <param name="userName">The name of the user.</param>
		/// <returns>The flag indicating if user exists.</returns>
		public bool CheckIfUserExists(string userName)
		{
			BeginTransaction();
			int count = Context.tUsers.Where(u => u.UserName.Equals(userName)).Count();
			EndTransaction();
			return count == 0 ? false : true;
		}

		/// <summary>
		/// Sets IsValid property to false for user specified by id.
		/// </summary>
		/// <param name="id">THe id of a user.</param>
		public void DeleteUser(int id)
		{
			BeginTransaction();
			tUser result = Context.tUsers.Find(id);
			if (result == null)
			{
				throw new UserNotFoundException();
			}
			result.IsValid = false;
			Context.SaveChanges();
			EndTransaction();

			CloseUserDocuments(id);
		}

		/// <summary>
		/// Saves password hash for user specified with username.
		/// </summary>
		/// <param name="userName"></param>
		/// <param name="passwordHash"></param>
		public UserDTO SaveUserPassword(string userName, string passwordHash)
		{
			BeginTransaction();
			tUser result = Context.tUsers.Where(u => u.UserName.Equals(userName) && u.IsValid).SingleOrDefault();
			if (result == null)
			{
				throw new UserNotFoundException();
			}

			result.HasEmptyPassword = false;
			result.PasswordHash = passwordHash;
			Context.SaveChanges();
			EndTransaction();
			return Mapper.Map<UserDTO>(result);
		}

		public void ResetUserPassword(int id)
		{
			BeginTransaction();
			tUser result = Context.tUsers.Find(id);
			if (result == null)
			{
				throw new UserNotFoundException();
			}
			result.HasEmptyPassword = true;
			Context.SaveChanges();
			EndTransaction();
		}

		/// <summary>
		/// Saves the newly created user DTO.
		/// </summary>
		public UserDTO SaveUserDTO(UserDTO user)
		{
			tUser result = Mapper.Map<tUser>(user);
			result.Version = 1;
			result.Guid = Guid.NewGuid();
			result.CreatedAt = DateTime.Now;
			BeginTransaction();
			Context.tUsers.Add(result);
			Context.SaveChanges();
			EndTransaction();
			if (user.AuthorizationRole == AuthorizationRoleCodes.Administrator)
			{
				AddDocumentsToAdministrator(result.Id);
			}

			return user;
		}

		/// <summary>
		/// Updates user DTO.
		/// </summary>
		public void UpdateUserDTO(UserDTO userDto)
		{
			BeginTransaction();
			tUser user = Context.tUsers.Find(userDto.Id);
			if (user == null)
			{
				throw new UserNotFoundException();
			}

			Mapper.Map(userDto, user);
			user.Version++;
			Context.SaveChanges();
			EndTransaction();
		}

		/// <summary>
		/// Loads list of users for auto suggest sharing control. Only valid operators will be loaded.
		/// If document is new, the owner of the document will not be loaded, that is current user.
		/// If document is not new all users that already can access document will not be loaded.
		/// </summary>
		/// <param name="documentId">The document Id.</param>
		/// <returns></returns>
		public IEnumerable<UserDTO> LoadUsersForShareAutosuggest(DocumentDTO documentDTo, int loggedUserId)
		{
			Expression<Func<tUser, bool>> restriction = u => u.IsValid && u.AuthorizationRoleId == (int)AuthorizationRoleCodes.Operator;

			if (documentDTo != null)
			{
				restriction = ExpressionUtils.AndOperation(restriction, u => !u.tUserDocuments.Any(x => x.DocumentId == documentDTo.Id && x.UserId == u.Id));
			}
			else
			{
				restriction = ExpressionUtils.AndOperation(restriction, u => u.Id != loggedUserId);
			}

			using (DMSDataBaseEntities context = new DMSDataBaseEntities())
			{
				return Mapper.Map<IEnumerable<UserDTO>>(context.tUsers.Where(restriction));
			}
		}

		/// <summary>
		/// Gives modify access right for all documents in system to admistrator. This method is called when new administrator is added to system.
		/// </summary>
		/// <param name="documentId">The specified </param>
		private void AddDocumentsToAdministrator(int userId)
		{
			BeginTransaction();
			IEnumerable<tDocument> documents = Context.tDocuments.Where(u => u.IsValid);
			foreach (tDocument document in documents)
			{
				tUserDocument ud = new tUserDocument()
				{
					DocumentId = document.Id,
					IsReading = false,
					IsWriting = false,
					DocumentAccessRightId = (int)DocumentAccessRightCodes.Modify,
					UserId = userId
				};

				Context.tUserDocuments.Add(ud);
			}

			Context.SaveChanges();
			EndTransaction();
		}

		/// <summary>
		/// Closes all documents for user. Used when deleting user.
		/// </summary>
		/// <param name="userId">The user id.</param>
		public void CloseUserDocuments(int userId)
		{
			BeginTransaction();
			IEnumerable<tUserDocument> shares = Context.tUserDocuments.Where(u => u.UserId == userId);
			foreach (tUserDocument ud in shares)
			{
				ud.IsReading = false;
				ud.IsWriting = false;
			}
			Context.SaveChanges();
			EndTransaction();
		}
	}
}
