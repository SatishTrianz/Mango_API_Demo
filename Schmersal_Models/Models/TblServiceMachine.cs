using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblServiceMachine")]
    public class TblServiceMachine
    {
        [Key]
        [Column(TypeName = "varchar(80)")]
        public string id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string service_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string machine_id { get; set; }

        public virtual TblMachine Machine { get; set; }
        public virtual TblService Service { get; set; }
    }
}
