using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblMachine")]
    public class TblMachine
    {
        public TblMachine()
        {
            TblServiceMachines = new HashSet<TblServiceMachine>();
        }

        [Key]
        [Column(TypeName = "varchar(80)")]
        public string id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string master_machine_id { get; set; }
        [Column(TypeName = "varchar(160)")]
        public string machine_name { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string asset_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string serial_number { get; set; }
        [Column(TypeName = "varbinary(150)")]
        public byte[] machine_description { get; set; }
        [Column(TypeName = "int")]
        public int estimated_hours { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset created_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string created_by { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset modified_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string modified_by { get; set; }

        public virtual TblMasterMachine MasterMachine { get; set; }
        public virtual ICollection<TblServiceMachine> TblServiceMachines { get; set; }
    }
}
