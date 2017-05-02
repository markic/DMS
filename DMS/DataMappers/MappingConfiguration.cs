using System;
using AutoMapper;
using DMS.DomainModel;
using DMS.DTO;

namespace DMS.DataMappers
{
	public static class MappingConfiguration
	{
		public static void GenerateMapConfiguration()
		{
			// POCO to DTO
			Mapper.CreateMap<tUser, UserDTO>()
				.ForMember(u => u.AuthorizationRole, opts => opts.MapFrom(u => (AuthorizationRoleCodes)u.AuthorizationRoleId));

			Mapper.CreateMap<tDocument, DocumentDTO>();
			Mapper.CreateMap<tDocumentVersion, DocumentVersionDTO>();
			Mapper.CreateMap<tKeyword, KeywordDTO>();

			Mapper.CreateMap<tComment, CommentDTO>()
				.ForMember(u => u.UserName, opts => opts.MapFrom(u => String.IsNullOrEmpty(u.tUser.FirstName) || String.IsNullOrEmpty(u.tUser.LastName) ? u.tUser.UserName : u.tUser.FirstName + " " + u.tUser.LastName));

			// DTO to PCO
			Mapper.CreateMap<UserDTO, tUser>()
				.ForMember(u => u.Guid, opts => opts.Ignore())
				.ForMember(u => u.Version, opts => opts.Ignore())
				.ForMember(u => u.Id, opts => opts.Ignore())
				.ForMember(u => u.AuthorizationRoleId, opts => opts.MapFrom(u => (int)u.AuthorizationRole));

			Mapper.CreateMap<CommentDTO, tComment>();
			Mapper.CreateMap<DocumentDTO, tDocument>();
			Mapper.CreateMap<KeywordDTO, tKeyword>();
		}
	}
}
