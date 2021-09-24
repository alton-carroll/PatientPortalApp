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

namespace PatientPortalApp.Controllers
{
    public class Treatments1Controller : Controller
    {
        private PatientPortalAppContext db = new PatientPortalAppContext();

        // GET: Treatments1
        public async Task<ActionResult> Index()
        {
            var treatments = db.Treatments.Include(t => t.Patient);
            return View(await treatments.ToListAsync());
        }

        // GET: Treatments1/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = await db.Treatments.FindAsync(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }

        // GET: Treatments1/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName");
            return View();
        }

        // POST: Treatments1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TreatmentId,TreatmentDate,TreatDescription,Created,CreatedBy,Modified,ModifiedBy,PatientId")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db.Treatments.Add(treatment);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName", treatment.PatientId);
            return View(treatment);
        }

        // GET: Treatments1/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = await db.Treatments.FindAsync(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName", treatment.PatientId);
            return View(treatment);
        }

        // POST: Treatments1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TreatmentId,TreatmentDate,TreatDescription,Created,CreatedBy,Modified,ModifiedBy,PatientId")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(treatment).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName", treatment.PatientId);
            return View(treatment);
        }

        // GET: Treatments1/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = await db.Treatments.FindAsync(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }

        // POST: Treatments1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Treatment treatment = await db.Treatments.FindAsync(id);
            db.Treatments.Remove(treatment);
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
