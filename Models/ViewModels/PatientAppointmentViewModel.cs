using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PatientPortalApp.Models;

namespace PatientPortalApp.Models.ViewModels
{
	public class PatientAppointmentViewModel: BaseEntity
	{
		public int PatientAppointmentViewModelId { get; set; }

		[ForeignKey("Patient")]
		public int PatientId { get; set; }
		[ForeignKey("Provider")]
		public int ProviderId { get; set; }


		public virtual Patient Patient { get; set; }
		public virtual Provider Provider { get; set; }
	}
}