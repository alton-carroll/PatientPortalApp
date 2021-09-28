using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientPortalApp.Models
{
	public class BaseEntity
	{

		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }
	}
}