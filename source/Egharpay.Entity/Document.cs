namespace Egharpay.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Document")]
    public partial class Document
    {
        public int DocumentId { get; set; }

        [StringLength(50)]
        public string PersonnelId { get; set; }

        [Required]
        [StringLength(100)]
        public string StudentCode { get; set; }

        
        [StringLength(500)]
        public string StudentName { get; set; }

        [Required]
        [StringLength(4000)]
        public string FileName { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        public string Location { get; set; }

        public int DocumentTypeId { get; set; }

        public Guid Guid { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime? DownloadedDateTime { get; set; }

        public int? CentreId { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public string Product { get; set; }

        public virtual DocumentCategory DocumentType { get; set; }

        public virtual Personnel Personnel { get; set; }

    }
}
