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
using Microsoft.Ajax.Utilities;
using Kendo.Mvc.Extensions;

namespace PatientPortalApp.Controllers
	{
	public class TreatmentsController : Controller
		{
		private PatientPortalAppContext db = new PatientPortalAppContext();

		public ActionResult Read_Treatment([DataSourceRequest] DataSourceRequest request, int id)
			{
			return Json(db.Treatments.Where(t => t.PatientId == id).ToDataSourceResult(request, t => new Treatment()
				{
				TreatmentDate = t.TreatmentDate,
				TreatDescription = t.TreatDescription

				}));
			}




		// GET: Treatments
		public async Task<ActionResult> Index()
			{
			var treatments = db.Treatments.Include(t => t.Patient);
			return View(await treatments.ToListAsync());
			}

		// GET: Treatments/Details/5
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

		// GET: Treatments/Create
		public ActionResult Create()
			{
			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix");
			return View();
			}

		// POST: Treatments/Create
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

			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix", treatment.PatientId);
			return View(treatment);
			}

		// GET: Treatments/Edit/5
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
			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix", treatment.PatientId);
			return View(treatment);
			}

		// POST: Treatments/Edit/5
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
			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix", treatment.PatientId);
			return View(treatment);
			}

		// GET: Treatments/Delete/5
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

		// POST: Treatments/Delete/5
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
