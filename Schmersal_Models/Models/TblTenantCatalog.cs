using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblTenantCatalog")]
    public class TblTenantCatalog
    {
        [Key]
        [Column(TypeName = "varchar(80)")]
        public string id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string client_name { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string region { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string country { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string language { get; set; }
    }
}
