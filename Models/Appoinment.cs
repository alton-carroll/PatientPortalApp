using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PatientPortalApp.Models
    {
    public class Appoinment
        {
        [Display(Name = "Appointment ID")]
        [Key]
        public int AppointmentId { get; set; }

        [Display(Name = "First Name")]
        //[Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        //[Required]
        public string LastName { get; set; }

        [Display(Name = "Appointment Date")]
        //[Required]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }
        }
    }