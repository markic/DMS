﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DMS.DomainModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DMSDataBaseEntities : DbContext
    {
        public DMSDataBaseEntities()
            : base("name=DMSDataBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tAuthorizationRole> tAuthorizationRoles { get; set; }
        public virtual DbSet<tComment> tComments { get; set; }
        public virtual DbSet<tDocument> tDocuments { get; set; }
        public virtual DbSet<tDocumentAccessRight> tDocumentAccessRights { get; set; }
        public virtual DbSet<tDocumentVersion> tDocumentVersions { get; set; }
        public virtual DbSet<tKeyword> tKeywords { get; set; }
        public virtual DbSet<tUser> tUsers { get; set; }
        public virtual DbSet<tUserDocument> tUserDocuments { get; set; }
    }
}
