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
    public class Vitals1Controller : Controller
    {
        private PatientPortalAppContext db = new PatientPortalAppContext();

        // GET: Vitals1
        public async Task<ActionResult> Index()
        {
            var vitals = db.Vitals.Include(v => v.Patient);
            return View(await vitals.ToListAsync());
        }

        // GET: Vitals1/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vital vital = await db.Vitals.FindAsync(id);
            if (vital == null)
            {
                return HttpNotFound();
            }
            return View(vital);
        }

        // GET: Vitals1/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName");
            return View();
        }

        // POST: Vitals1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "VitalId,VitalDate,Weight,Height,Temperature,BloodPressure,Pulse,Created,CreatedBy,Modified,ModifiedBy,PatientId")] Vital vital)
        {
            if (ModelState.IsValid)
            {
                db.Vitals.Add(vital);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName", vital.PatientId);
            return View(vital);
        }

        // GET: Vitals1/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vital vital = await db.Vitals.FindAsync(id);
            if (vital == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName", vital.PatientId);
            return View(vital);
        }

        // POST: Vitals1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "VitalId,VitalDate,Weight,Height,Temperature,BloodPressure,Pulse,Created,CreatedBy,Modified,ModifiedBy,PatientId")] Vital vital)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vital).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName", vital.PatientId);
            return View(vital);
        }

        // GET: Vitals1/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vital vital = await db.Vitals.FindAsync(id);
            if (vital == null)
            {
                return HttpNotFound();
            }
            return View(vital);
        }

        // POST: Vitals1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Vital vital = await db.Vitals.FindAsync(id);
            db.Vitals.Remove(vital);
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
