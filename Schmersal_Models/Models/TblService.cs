using SSchmersal_Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblService")]
    public class TblService
    {
        public TblService()
        {
            TblServiceMachines = new HashSet<TblServiceMachine>();
        }

        [Key]
        [Column(TypeName = "varchar(80)")]
        public string id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string erp_wbs_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string project_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string offer_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string contact_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string service_type { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string service_location { get; set; }
        [Column(TypeName = "varchar(80)")]
        public DateTime? start_date { get; set; }
        [Column(TypeName = "varchar(80)")]
        public DateTime? end_date { get; set; }
        [Column(TypeName = "int")]
        public int actual_hours { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string is_active { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset created_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string created_by { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset modified_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string modified_by { get; set; }

        public virtual TblContact Contact { get; set; }
        public virtual TblOffer Offer { get; set; }
        public virtual TblProject Project { get; set; }
        public virtual ICollection<TblServiceMachine> TblServiceMachines { get; set; }
    }
}
