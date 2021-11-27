using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Schmersal_Models.Models
{
    public class Customer
    {
        [Key]
        [Column(TypeName = "varchar(50)")]
        public string Id { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Customer_Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Erp_Customer_Id { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Country_Code { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Contact_Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string City { get; set; }
        [Column(TypeName = "int")]
        public int ZipCode { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Street { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Phone_Number { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Language { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset Created_At { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Created_By { get; set; }

        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset Modified_At { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Modified_By { get; set; }

        //public List<Project> Projects { get; set; }
    }
}
