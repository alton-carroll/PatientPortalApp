using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientPortalApp.Models
    {
    public class Medication
        {
        
        [Key]
        [Display(Name = "Medication ID")]
        public int MedicationId { get; set; }
        [Display(Name = "Medication Details")]
        public string MedicationName { get; set; }
        [Display(Name = "Description / Reason")]
        public string MedDescription { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        }
    }