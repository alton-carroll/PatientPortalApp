using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PatientPortalApp.Models;

namespace PatientPortalApp.Models.ViewModels
	{
	public class AppointmentViewModel
		{
		public IEnumerable<Patient> Patients { get; set; }
		public IEnumerable<Provider> Providers { get; set; }
		public IEnumerable<Appointment> Appointments { get; set; }
		}
	}