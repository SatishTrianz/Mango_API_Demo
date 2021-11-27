using System;
using System.Collections.Generic;
using System.Text;

namespace Schmersal_Models.ApiModels
{
    public class OfferStatusAPIModel
    {
        public string quote_type { get; set; }
        public string notes { get; set; }
        public string offer_id { get; set; }
        public string project_id { get; set; }
        public string contact_id { get; set; }
        public string contact_email { get; set; }
        public string contact_address { get; set; }
        public string contact_number { get; set; }
        public string customer_id { get; set; }
        public string customer_name { get; set; }
        public string customer_address { get; set; }
        public string Description {get;set;}
        public string Status { get; set; }
        public DateTime offer_date { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
    }
}
