using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schmersal_Models.Models
{
    [Table("tblProject")]
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "varchar(80)")]
        public string Id { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Erp_Project_Id { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Project_Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Description { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Start_Date { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? End_Date { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Status { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Controlling_Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Tenant_Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Company_Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Customer_Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Staff_Id { get; set; }

        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset Created_At { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Created_By { get; set; }

        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset Modified_At { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Modified_By { get; set; }
    }
}
