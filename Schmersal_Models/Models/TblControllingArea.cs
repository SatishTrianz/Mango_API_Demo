using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblControllingArea")]
    public class TblControllingArea
    {
        [Key]
        [Column(TypeName = "varchar(50)")]
        public string id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string controlling_area { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string controlling_area_code { get; set; }
    }
}
