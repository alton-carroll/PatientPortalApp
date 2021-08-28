using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientPortalApp.Models
	{
	public class Referral
		{
		[Key]
		public int ReferralId { get; set; }
		[DataType(DataType.Date)]
		public DateTime ReferralDate { get; set; }
		public string Doctor { get; set; }
		public string ReferralDoctor { get; set; }
		public string Procedure { get; set; }
		public string Location { get; set; }
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