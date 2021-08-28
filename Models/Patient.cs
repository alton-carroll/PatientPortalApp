﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PatientPortalApp.Models
	{
	public class Patient
		{
		[Display(Name = "Patient ID")]
		[Key]
		public int PatientId { get; set; }
		public string Prefix { get; set; }
		[Display(Name = "First Name")]
		//[Required]
		public string FirstName { get; set; }
		[Display(Name = "Middle Name")]
		//[Required]
		public string MiddleName { get; set; }
		[Display(Name = "Last Name")]
		//[Required]
		public string LastName { get; set; }
		public string Suffix { get; set; }

		[Display(Name = "Full Name")]
		public string FullName
			{
			get { return FirstName + " " + MiddleName + " " + LastName + " " + Suffix; }
			}
		[DataType(DataType.Date)]
		[Display(Name = "Date of Birth")]
		//[Required]
		public DateTime BirthDate { get; set; }
		[Display(Name = "Social Security Number")]
		//[Required]
		public string Ssn { get; set; }
		[Display(Name = "Active Patient?")]
		public bool ActivePatient { get; set; }

		//[Required]
		public string Street { get; set; }
		//[Required]
		public string Apartment { get; set; }
		public string City { get; set; }
		//[Required]
		public string State { get; set; }
		//[Required]
		public string Zip { get; set; }


		//Insurance Data
		[Display(Name = "Primary Insurance Provider")]
		//[Required]
		public string PrimaryInsurance { get; set; }
		[Display(Name = "Primary Insurance ID Number")]
		//[Required]
		public string PrimaryInsuranceID { get; set; }
		[Display(Name = "Primary Insurance Holder")]
		//[Required]
		public string PrimaryInsuranceHolder { get; set; }

		[Display(Name = "Secondary Insurance Provider")]
		public string SecondaryInsurance { get; set; }
		[Display(Name = "Secondary Insurance ID Number")]
		public string SecondaryInsuranceID { get; set; }
		[Display(Name = "Secondary Insurance Holder")]
		public string SecondaryInsuranceHolder { get; set; }
		[Display(Name = "Has Outstanding Balance")]
		[DataType(DataType.Currency)]
		[Range(0, int.MaxValue)]
		public Decimal CurrentBalance { get; set; }

		public string CreatedBy { get; set; }
		[DataType(DataType.Date)]
		public DateTime Created { get; set; }
		public string ModifiedBy { get; set; }
		[DataType(DataType.Date)]
		public DateTime Modified { get; set; }
		public virtual ICollection<Medication> Medications { get; set; }
		public virtual ICollection<Referral> Referrals { get; set; }
		//public virtual ICollection<Appointment> Appoinments { get; set; }
		public virtual ICollection<Vital> Vitals { get; set; }
		}
	}