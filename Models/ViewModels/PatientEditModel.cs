using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PatientPortalApp.Models.ViewModels
    {
    public class PatientEditModel
        {
        [Key]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Appointment Appointment { get; set; }
        public virtual Vital Vital { get; set; }
        public virtual Treatment Treatment { get; set; }
        public virtual Referral Referral { get; set; }
        }
    }