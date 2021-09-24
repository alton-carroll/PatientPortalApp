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
		[DataType(DataType.Date)]
		[Display(Name = "Date Prescribed")]
		public DateTime MedicationDate { get; set; }
		[Display(Name = "Medication Details")]
		public string MedicationName { get; set; }
		[Display(Name = "Description / Reason")]
		public string MedDescription { get; set; }
		public string CreatedBy { get; set; }
		[DataType(DataType.Date)]
		public DateTime Created { get; set; }
		public string ModifiedBy { get; set; }
		[DataType(DataType.Date)]
		public DateTime Modified { get; set; }
		[ForeignKey("Patient")]
		public int PatientId { get; set; }
		public Patient Patient { get; set; }
		}
	}