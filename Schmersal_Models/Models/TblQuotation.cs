using SSchmersal_Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblQuotation")]
    public class TblQuotation
    {
        [Key]
        [Column(TypeName = "varchar(80)")]
        public string id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string offer_id { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string template_name { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string template_url { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string quotation_url { get; set; }
        [Column(TypeName = "varchar(80)")]
        public decimal? version { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset created_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string created_by { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset modified_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string modified_by { get; set; }

        public virtual TblOffer Offer { get; set; }
    }
}
