using Schmersal_Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SSchmersal_Models.Models
{
    public class TblOffer
    {
        public TblOffer()
        {
            TblQuotations = new HashSet<TblQuotation>();
            TblServices = new HashSet<TblService>();
        }

        [Key]
        [Column(TypeName = "varchar(80)")]
        public string id { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string quote_type { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string notes { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string project_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string contact_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string status { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset created_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string created_by { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset modified_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string modified_by { get; set; }

        public virtual TblContact Contact { get; set; }
        public virtual TblProject Project { get; set; }
        public virtual ICollection<TblQuotation> TblQuotations { get; set; }
        public virtual ICollection<TblService> TblServices { get; set; }
    }
}
