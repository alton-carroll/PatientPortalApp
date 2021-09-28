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
using PatientPortalApp.Models.ViewModels;

namespace PatientPortalApp.Controllers
{
    public class PatientAppointmentViewModelsController : Controller
    {
        private PatientPortalAppContext db = new PatientPortalAppContext();

        // GET: PatientAppointmentViewModels
        public async Task<ActionResult> Index()
        {
            var patientAppointmentViewModels = db.PatientAppointmentViewModels.Include(p => p.Patient).Include(p => p.Provider);
            return View(await patientAppointmentViewModels.ToListAsync());
        }

        // GET: PatientAppointmentViewModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientAppointmentViewModel patientAppointmentViewModel = await db.PatientAppointmentViewModels.FindAsync(id);
            if (patientAppointmentViewModel == null)
            {
                return HttpNotFound();
            }
            return View(patientAppointmentViewModel);
        }

        // GET: PatientAppointmentViewModels/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName");
            ViewBag.ProviderId = new SelectList(db.Providers, "ProviderId", "ProviderName");
            return View();
        }

        // POST: PatientAppointmentViewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "PatientAppointmentViewModelId,PatientId,ProviderId")] PatientAppointmentViewModel patientAppointmentViewModel)
        {
            if (ModelState.IsValid)
            {
                db.PatientAppointmentViewModels.Add(patientAppointmentViewModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName", patientAppointmentViewModel.PatientId);
            ViewBag.ProviderId = new SelectList(db.Providers, "ProviderId", "ProviderName", patientAppointmentViewModel.ProviderId);
            return View(patientAppointmentViewModel);
        }

        // GET: PatientAppointmentViewModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientAppointmentViewModel patientAppointmentViewModel = await db.PatientAppointmentViewModels.FindAsync(id);
            if (patientAppointmentViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName", patientAppointmentViewModel.PatientId);
            ViewBag.ProviderId = new SelectList(db.Providers, "ProviderId", "ProviderName", patientAppointmentViewModel.ProviderId);
            return View(patientAppointmentViewModel);
        }

        // POST: PatientAppointmentViewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "PatientAppointmentViewModelId,PatientId,ProviderId")] PatientAppointmentViewModel patientAppointmentViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientAppointmentViewModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName", patientAppointmentViewModel.PatientId);
            ViewBag.ProviderId = new SelectList(db.Providers, "ProviderId", "ProviderName", patientAppointmentViewModel.ProviderId);
            return View(patientAppointmentViewModel);
        }

        // GET: PatientAppointmentViewModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientAppointmentViewModel patientAppointmentViewModel = await db.PatientAppointmentViewModels.FindAsync(id);
            if (patientAppointmentViewModel == null)
            {
                return HttpNotFound();
            }
            return View(patientAppointmentViewModel);
        }

        // POST: PatientAppointmentViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            PatientAppointmentViewModel patientAppointmentViewModel = await db.PatientAppointmentViewModels.FindAsync(id);
            db.PatientAppointmentViewModels.Remove(patientAppointmentViewModel);
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
