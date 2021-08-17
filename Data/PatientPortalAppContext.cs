﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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
    
        public PatientPortalAppContext() : base("name=PatientPortalAppContext")
        {
        }

        public System.Data.Entity.DbSet<PatientPortalApp.Models.Patient> Patients { get; set; }

        public System.Data.Entity.DbSet<PatientPortalApp.Models.Referral> Referrals { get; set; }

        public System.Data.Entity.DbSet<PatientPortalApp.Models.Appoinment> Appoinments { get; set; }
        }
}