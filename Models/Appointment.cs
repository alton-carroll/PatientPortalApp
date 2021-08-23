using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientPortalApp.Models
    {
    public class Appointment
        {
        //[Key]
        //[Display(Name = "Appointment ID")]
        //public int AppointmentId { get; set; }
        [Display(Name = "Appointment Date")]
        //[Required]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime Modified { get; set; }
        public string Reason { get; set; }
        [Key]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public int ProviderId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Provider Provider { get; set; }

        }
    }