using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using PatientPortalApp.Models;

namespace PatientPortalApp.Data
	{
	public class PatientPortalAppContext : DbContext
		{
		// You can add custom code to this file. Changes will not be overwritten.
		//
		// If you want Entity Framework to drop and regenerate your database
		// automatically whenever you change your model schema, please use data migrations.
		// For more information refer to the documentation:
		// http://msdn.microsoft.com/en-us/data/jj591621.aspx
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
			//modelBuilder.Entity<Appointment>()
			//	.Property(p => p.AppointmentDate)
			//	.HasColumnType("datetime2")
			//	.HasPrecision(0);
			//modelBuilder.Entity<Patient>()
			//	.Property(P => P.BirthDate)
			//	.HasColumnType("datetime2");
		}
		public PatientPortalAppContext() : base("name=PatientPortalAppContext")
			{

			}
		public System.Data.Entity.DbSet<PatientPortalApp.Models.Patient> Patients { get; set; }
		public System.Data.Entity.DbSet<PatientPortalApp.Models.Referral> Referrals { get; set; }
		public System.Data.Entity.DbSet<PatientPortalApp.Models.Appointment> Appointments { get; set; }
		public System.Data.Entity.DbSet<PatientPortalApp.Models.Provider> Providers { get; set; }
		public System.Data.Entity.DbSet<PatientPortalApp.Models.Medication> Medications { get; set; }
		public System.Data.Entity.DbSet<PatientPortalApp.Models.Vital> Vitals { get; set; }
		public System.Data.Entity.DbSet<PatientPortalApp.Models.Treatment> Treatments { get; set; }

		public System.Data.Entity.DbSet<PatientPortalApp.Models.ViewModels.PatientAppointmentViewModel> PatientAppointmentViewModels { get; set; }
	}
	}
