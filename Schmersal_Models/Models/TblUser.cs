using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblUser")]
    public class TblUser
    {
        public TblUser()
        {
            TblProjectStaffs = new HashSet<TblProjectStaff>();
        }

        [Key]
        [Column(TypeName = "varchar(80)")]
        public string id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string first_name { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string last_name { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string display_name { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string login_name { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string email_address { get; set; }

        public virtual ICollection<TblProjectStaff> TblProjectStaffs { get; set; }
    }
}
