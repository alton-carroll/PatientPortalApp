using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientPortalApp.Models
	{
	public class Treatment
		{
		[Display(Name = "Treatment ID")]
		public int TreatmentId { get; set; }
		[Display(Name = "Treatment Date")]
		[DataType(DataType.Date)]
		public DateTime TreatmentDate { get; set; }
		[Display(Name = "Treatment Description")]
		public string TreatDescription { get; set; }
		[DataType(DataType.Date)]
		public DateTime Created { get; set; }
		public string CreatedBy { get; set; }
		[DataType(DataType.Date)]
		public DateTime Modified { get; set; }
		public string ModifiedBy { get; set; }
		[Display(Name = "Patient ID")]
		[ForeignKey("Patient")]
		public int PatientId { get; set; }
		public virtual Patient Patient { get; set; }
		}
	}