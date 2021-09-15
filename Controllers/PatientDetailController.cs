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
        // GET: PatientDetail
        public ActionResult Index()
        {
            return View();
        }
    }
}