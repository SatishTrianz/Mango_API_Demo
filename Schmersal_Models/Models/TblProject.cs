using SSchmersal_Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblProject")]
    public class TblProject
    {
        public TblProject()
        {
            TblOffers = new HashSet<TblOffer>();
            TblServices = new HashSet<TblService>();
        }

        [Key]
        [Column(TypeName = "varchar(80)")]
        public string id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string erp_project_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string project_name { get; set; }
        [Column(TypeName = "varchar(160)")]
        public string description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime start_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? end_date { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string status { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string controlling_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string tenant_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string company_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string customer_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string staff_id { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset created_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string created_by { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset modified_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string modified_by { get; set; }

        public virtual ICollection<TblOffer> TblOffers { get; set; }
        public virtual ICollection<TblService> TblServices { get; set; }
    }
}
