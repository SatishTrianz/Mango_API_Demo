using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblErpCustomer")]
    public class TblErpCustomer
    {
        [Key]
        [Column(TypeName = "varchar(50)")]
        public string erp_customer_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string company_name { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string company_code { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string controlling_area { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string controlling_area_code { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string customer_id { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string customer_name { get; set; }
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
    }
}
