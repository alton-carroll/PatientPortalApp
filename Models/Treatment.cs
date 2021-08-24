﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientPortalApp.Models
    {
    public class Treatment
        {
        public int TreatmentId { get; set; }
        [DataType(DataType.Date)]
        public DateTime TreatmentDate { get; set; }
        public string TreatDescription { get; set; }
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