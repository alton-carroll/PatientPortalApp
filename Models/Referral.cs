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
		[Display(Name = "Referral ID")]
		[Key]
		public int ReferralId { get; set; }
		[Display(Name = "Referral Date")]
		[DataType(DataType.Date)]
		public DateTime ReferralDate { get; set; }
		[Display(Name = "Referring Doctor")]
		public string Doctor { get; set; }
		[Display(Name = "Reffered Doctor")]
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
		public virtual Patient Patient { get; set; }

		}
	}