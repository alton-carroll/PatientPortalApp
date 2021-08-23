using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PatientPortalApp.Data;
using PatientPortalApp.Models;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace PatientPortalApp.Controllers
{
    public class PatientsController : Controller
    {
        public ActionResult ReadPatient([DataSourceRequest] DataSourceRequest request)
            {
            using (var context = new PatientPortalAppContext())
                {
                return Json(context.Patients.ToDataSourceResult(request, p => new Patient
                    {
                    PatientId = p.PatientId,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    ActivePatient = p.ActivePatient,
                    }));
                }
            }

        public ActionResult UpdatePatient(Patient patient)
            {
            if (patient != null && ModelState.IsValid)
                {
                var target = GetPatientById(patient.PatientId);
                target.Prefix = patient.Prefix;
                target.FirstName = patient.FirstName;
                target.LastName = patient.LastName;
                target.Suffix = patient.Suffix;
                target.BirthDate = patient.BirthDate;
                target.Ssn = patient.Ssn;
                target.ActivePatient = patient.ActivePatient;
                target.Street = patient.Street;
                target.City = patient.City;
                target.State = patient.State;
                target.Zip = patient.Zip;
                target.PrimaryInsurance = patient.PrimaryInsurance;
                target.PrimaryInsuranceID = patient.PrimaryInsuranceID;
                target.PrimaryInsuranceHolder = patient.PrimaryInsuranceHolder;
                target.SecondaryInsurance = patient.SecondaryInsurance;
                target.SecondaryInsuranceID = patient.SecondaryInsuranceID;
                target.SecondaryInsuranceHolder = patient.SecondaryInsuranceHolder;
                db.SaveChanges();
                }
            return Json(ModelState.ToDataSourceResult());
            }

        public ActionResult CreatePatient(Patient patient)
            {
            if (patient != null && ModelState.IsValid)
                {
                var target = new Patient();
                target.Prefix = patient.Prefix;
                target.FirstName = patient.FirstName;
                target.LastName = patient.LastName;
                target.Suffix = patient.Suffix;
                target.BirthDate = patient.BirthDate;
                target.Ssn = patient.Ssn;
                target.ActivePatient = patient.ActivePatient;
                target.Street = patient.Street;
                target.City = patient.City;
                target.State = patient.State;
                target.Zip = patient.Zip;
                target.PrimaryInsurance = patient.PrimaryInsurance;
                target.PrimaryInsuranceID = patient.PrimaryInsuranceID;
                target.PrimaryInsuranceHolder = patient.PrimaryInsuranceHolder;
                target.SecondaryInsurance = patient.SecondaryInsurance;
                target.SecondaryInsuranceID = patient.SecondaryInsuranceID;
                target.SecondaryInsuranceHolder = patient.SecondaryInsuranceHolder;

                db.Patients.Add(target);
                db.SaveChanges();

                patient.PatientId = target.PatientId;
                }
            return Json(new[ ] { patient }.ToDataSourceResult(new DataSourceRequest(), ModelState));
            }

        public ActionResult DestroyPatient(int patientId)
            {
            var target = GetPatientById(patientId);
            db.Patients.Remove(target);
            db.SaveChanges();

            return Json(ModelState.ToDataSourceResult());
            }


        private Patient GetPatientById(int id)
            {
            return db.Patients.FirstOrDefault(p => p.PatientId == id);
            }





        //Auto-Generated Script below



        private PatientPortalAppContext db = new PatientPortalAppContext();

        // GET: Patients
        public async Task<ActionResult> Index()
        {
            return View(await db.Patients.ToListAsync());
        }

        // GET: Patients/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = await db.Patients.FindAsync(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // GET: Patients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "PatientId,Prefix,FirstName,MiddleName,LastName,Suffix,BirthDate,Ssn,ActivePatient,Street,Apartment,City,State,Zip,PrimaryInsurance,PrimaryInsuranceID,PrimaryInsuranceHolder,SecondaryInsurance,SecondaryInsuranceID,SecondaryInsuranceHolder,CurrentBalance,CreatedBy,Created,ModifiedBy,Modified")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Patients.Add(patient);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(patient);
        }

        // GET: Patients/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = await db.Patients.FindAsync(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "PatientId,Prefix,FirstName,MiddleName,LastName,Suffix,BirthDate,Ssn,ActivePatient,Street,Apartment,City,State,Zip,PrimaryInsurance,PrimaryInsuranceID,PrimaryInsuranceHolder,SecondaryInsurance,SecondaryInsuranceID,SecondaryInsuranceHolder,CurrentBalance,CreatedBy,Created,ModifiedBy,Modified")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patient).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(patient);
        }

        // GET: Patients/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = await db.Patients.FindAsync(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Patient patient = await db.Patients.FindAsync(id);
            db.Patients.Remove(patient);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
