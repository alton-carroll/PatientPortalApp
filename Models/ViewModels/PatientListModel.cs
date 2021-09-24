using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatientPortalApp.Models.ViewModels
	{
	public class PatientListModel
		{
		public int PatientListId { get; set; }
		public Patient Patient { get; set; }
		public IEnumerable<SelectListItem> SelectPatient { get; set; }

		public PatientListModel(Patient patient, IEnumerable spatient)
			{
			Patient = patient;
			SelectPatient = new SelectList(spatient, "Patient", "Name", patient.FullName);
			}
		}
	}