using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PatientPortalApp.Models
    {
    public class Provider
        {
        [Key]
        [Display(Name ="Provider ID")]
        public int ProviderId { get; set; }
        [Display(Name = "Provider Name")]
        public string ProviderName { get; set; }
        public string Specialty { get; set; }
        }
    }