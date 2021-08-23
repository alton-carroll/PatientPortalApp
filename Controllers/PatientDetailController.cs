using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatientPortalApp.Data;
using PatientPortalApp.Models;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace PatientPortalApp.Controllers
{
    public class PatientDetailController : Controller
    {

        private PatientPortalAppContext db = new PatientPortalAppContext();

        public ActionResult Read_PatientDetail([DataSourceRequest] DataSourceRequest request, int id)
            {
            return Json(db.Patients.ToDataSourceResult(request, p => new Patient
                {
                PatientId = p.PatientId,
                Street = p.Street,
                City = p.City,
                State = p.State,
                Zip = p.Zip
                }));

            }


        private Patient GetPatientById(int id)
            {
            return db.Patients.FirstOrDefault(p => p.PatientId == id);
            }
    }
}