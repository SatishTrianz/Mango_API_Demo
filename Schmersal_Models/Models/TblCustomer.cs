using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblCustomer")]
    public class TblCustomer
    {
        [Key]
        [Column(TypeName = "varchar(50)")]
        public string id { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string customer_name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string erp_customer_id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string contact_id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string country_code { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string city { get; set; }
        [Column(TypeName = "varchar(50)")]
        public int? zipcode { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string street { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string phone_number { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string language { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset created_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string created_by { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset modified_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string modified_by { get; set; }

        public virtual TblContact Contact { get; set; }
    }
}
