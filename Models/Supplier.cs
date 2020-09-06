using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClientApp.Models
{
    public class Supplier
    {
        public int? SupplierID { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }
    }
}
