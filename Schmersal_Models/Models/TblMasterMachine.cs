using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblMachinemaster")]
    public class TblMasterMachine
    {
        
        public TblMasterMachine()
        {
            TblMachines = new HashSet<TblMachine>();
        }

        [Key]
        [Column(TypeName = "varchar(80)")]
        public string id { get; set; }
        [Column(TypeName = "varchar(160)")]
        public string machine_name { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string machine_type { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string manufacturer { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset created_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string created_by { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset modified_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string modified_by { get; set; }

        public virtual ICollection<TblMachine> TblMachines { get; set; }
    }
}
