//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tDocumentVersion
    {
        public tDocumentVersion()
        {
            this.tComments = new HashSet<tComment>();
        }
    
        public int Id { get; set; }
        public int Version { get; set; }
        public System.Guid Guid { get; set; }
        public int HierarchyId { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public string FilePath { get; set; }
        public int DocumentId { get; set; }
    
        public virtual ICollection<tComment> tComments { get; set; }
        public virtual tDocument tDocument { get; set; }
    }
}
