using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblCompany")]
    public class TblCompany
    {
        [Key]
        [Column(TypeName = "varchar(50)")]
        public string Id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string company_name { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string company_code { get; set; }
    }
}
