using SSchmersal_Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Schmersal_Models.Models
{
    [Table("tblContact")]
    public class TblContact
    {
        public TblContact()
        {
            TblCustomers = new HashSet<TblCustomer>();
            TblOffers = new HashSet<TblOffer>();
            TblServices = new HashSet<TblService>();
        }

        [Key]
        [Column(TypeName = "varchar(50)")]
        public string contact_id { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string first_name { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string last_name { get; set; }
        [Column(TypeName = "varchar(160)")]
        public string display_name { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string email_address { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string title { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string language { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string phone_number { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string department { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset created_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string created_by { get; set; }
        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset modified_at { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string modified_by { get; set; }

        public virtual ICollection<TblCustomer> TblCustomers { get; set; }
        public virtual ICollection<TblOffer> TblOffers { get; set; }
        public virtual ICollection<TblService> TblServices { get; set; }
    }
}
