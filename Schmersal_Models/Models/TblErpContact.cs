using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblErpContact")]
    public class TblErpContact
    {
        [Key]
        [Column(TypeName = "varchar(50)")]
        public string erp_contact_id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string first_name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string customer_id { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string last_name { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string display_name { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string email_address { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string title { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string language { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string phone_number { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string department { get; set; }
    }
}
