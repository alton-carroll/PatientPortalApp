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
	public class MedicationsController : Controller
		{
		private PatientPortalAppContext db = new PatientPortalAppContext();

		public ActionResult Read_Medication([DataSourceRequest] DataSourceRequest request, int id)
			{
			return Json(db.Medications.Where(m => m.PatientId == id).ToDataSourceResult(request, m => new Medication()
				{
				MedicationDate = m.MedicationDate,
				MedicationName = m.MedicationName
				}));
			}

		// GET: Medications
		public async Task<ActionResult> Index()
			{
			var medications = db.Medications.Include(m => m.Patient);
			return View(await medications.ToListAsync());
			}

		// GET: Medications/Details/5
		public async Task<ActionResult> Details(int? id)
			{
			if (id == null)
				{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
				}
			Medication medication = await db.Medications.FindAsync(id);
			if (medication == null)
				{
				return HttpNotFound();
				}
			return View(medication);
			}

		// GET: Medications/Create
		public ActionResult Create()
			{
			ViewBag.PatientId = new SelectList(db.Patients, "PatientId");
			return View();
			}

		// POST: Medications/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to, for
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create([Bind(Include = "MedicationId,MedicationName,MedDescription,PatientId")] Medication medication)
			{
			if (ModelState.IsValid)
				{
				db.Medications.Add(medication);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
				}

			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix", medication.PatientId);
			return View(medication);
			}

		// GET: Medications/Edit/5
		public async Task<ActionResult> Edit(int? id)
			{
			if (id == null)
				{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
				}
			Medication medication = await db.Medications.FindAsync(id);
			if (medication == null)
				{
				return HttpNotFound();
				}
			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix", medication.PatientId);
			return View(medication);
			}

		// POST: Medications/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to, for
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit([Bind(Include = "MedicationId,MedicationName,MedDescription,PatientId")] Medication medication)
			{
			if (ModelState.IsValid)
				{
				db.Entry(medication).State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
				}
			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix", medication.PatientId);
			return View(medication);
			}

		// GET: Medications/Delete/5
		public async Task<ActionResult> Delete(int? id)
			{
			if (id == null)
				{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
				}
			Medication medication = await db.Medications.FindAsync(id);
			if (medication == null)
				{
				return HttpNotFound();
				}
			return View(medication);
			}

		// POST: Medications/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(int id)
			{
			Medication medication = await db.Medications.FindAsync(id);
			db.Medications.Remove(medication);
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
