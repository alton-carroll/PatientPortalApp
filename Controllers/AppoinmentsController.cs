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
    public class AppoinmentsController : Controller
    {
        private PatientPortalAppContext db = new PatientPortalAppContext();

        // GET: Appoinments
        public async Task<ActionResult> Index()
        {
            return View(await db.Appoinments.ToListAsync());
        }

        // GET: Appoinments/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appoinment appoinment = await db.Appoinments.FindAsync(id);
            if (appoinment == null)
            {
                return HttpNotFound();
            }
            return View(appoinment);
        }

        // GET: Appoinments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Appoinments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AppointmentId,FirstName,LastName,AppointmentDate")] Appoinment appoinment)
        {
            if (ModelState.IsValid)
            {
                db.Appoinments.Add(appoinment);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(appoinment);
        }

        // GET: Appoinments/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appoinment appoinment = await db.Appoinments.FindAsync(id);
            if (appoinment == null)
            {
                return HttpNotFound();
            }
            return View(appoinment);
        }

        // POST: Appoinments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AppointmentId,FirstName,LastName,AppointmentDate")] Appoinment appoinment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appoinment).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(appoinment);
        }

        // GET: Appoinments/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appoinment appoinment = await db.Appoinments.FindAsync(id);
            if (appoinment == null)
            {
                return HttpNotFound();
            }
            return View(appoinment);
        }

        // POST: Appoinments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Appoinment appoinment = await db.Appoinments.FindAsync(id);
            db.Appoinments.Remove(appoinment);
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
