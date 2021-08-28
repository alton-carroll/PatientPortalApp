using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientPortalApp.Models
	{
	public class Vital
		{
		public int VitalId { get; set; }
		[DataType(DataType.Date)]
		public DateTime VitalDate { get; set; }
		public string Weight { get; set; }
		public string Height { get; set; }
		public string Temperature { get; set; }
		public string BloodPressure { get; set; }
		public string Pulse { get; set; }
		[DataType(DataType.Date)]
		public DateTime Created { get; set; }
		public string CreatedBy { get; set; }
		[DataType(DataType.Date)]
		public DateTime Modified { get; set; }
		public string ModifiedBy { get; set; }
		[ForeignKey("Patient")]
		public int PatientId { get; set; }


		public Patient Patient { get; set; }
		}
	}