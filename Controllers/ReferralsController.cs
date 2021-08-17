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
    public class ReferralsController : Controller
    {
        private PatientPortalAppContext db = new PatientPortalAppContext();

        // GET: Referrals
        public async Task<ActionResult> Index()
        {
            var referrals = db.Referrals.Include(r => r.Patient);
            return View(await referrals.ToListAsync());
        }

        // GET: Referrals/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Referral referral = await db.Referrals.FindAsync(id);
            if (referral == null)
            {
                return HttpNotFound();
            }
            return View(referral);
        }

        // GET: Referrals/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix");
            return View();
        }

        // POST: Referrals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ReferralId,ReferralDate,Doctor,ReferralDoctor,Procedure,Location,CreatedBy,Created,ModifiedBy,Modified,PatientId")] Referral referral)
        {
            if (ModelState.IsValid)
            {
                db.Referrals.Add(referral);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix", referral.PatientId);
            return View(referral);
        }

        // GET: Referrals/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Referral referral = await db.Referrals.FindAsync(id);
            if (referral == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix", referral.PatientId);
            return View(referral);
        }

        // POST: Referrals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ReferralId,ReferralDate,Doctor,ReferralDoctor,Procedure,Location,CreatedBy,Created,ModifiedBy,Modified,PatientId")] Referral referral)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referral).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix", referral.PatientId);
            return View(referral);
        }

        // GET: Referrals/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Referral referral = await db.Referrals.FindAsync(id);
            if (referral == null)
            {
                return HttpNotFound();
            }
            return View(referral);
        }

        // POST: Referrals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Referral referral = await db.Referrals.FindAsync(id);
            db.Referrals.Remove(referral);
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
