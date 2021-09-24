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
using System.Data.Entity.Migrations;

namespace PatientPortalApp.Controllers
	{
	public class VitalsController : Controller
		{
		private PatientPortalAppContext db = new PatientPortalAppContext();

		// Get vitals for patient detail view template

		public ActionResult Read_Vitals([DataSourceRequest] DataSourceRequest request, int id)
			{
			return Json(db.Vitals.Where(v => v.PatientId == id).ToDataSourceResult(request, v => new Vital()
				{
				VitalDate = v.VitalDate,
				Weight = v.Weight,
				Height = v.Height,
				Temperature = v.Temperature,
				BloodPressure = v.BloodPressure,
				Pulse = v.Pulse
				}));
			}

		// Update vitals for patient detail view template
		[AcceptVerbs(HttpVerbs.Post)]
		public ActionResult Update_Vitals([DataSourceRequest] DataSourceRequest request, Vital vital)
			{
			if (vital != null && ModelState.IsValid)
				{
				db.Vitals.AddOrUpdate(vital);
				}
			return Json(new[ ] { vital }.ToDataSourceResult(request, ModelState));
			}

		// Create vitals for patient detail view template

		public ActionResult Create_Vitals(Vital vital, int id)
			{
			if (id == 0)
				{
				ModelState.AddModelError("PatientId", "Add Patient First");
				}
			if (vital != null && ModelState.IsValid)
				{
				var target = new Vital();
				target.PatientId = vital.PatientId;
				target.VitalDate = vital.VitalDate;
				target.Weight = vital.Weight;
				target.Height = vital.Height;
				target.Temperature = vital.Temperature;
				target.BloodPressure = vital.BloodPressure;
				target.Pulse = vital.Pulse;
				db.Vitals.Add(target);
				db.SaveChanges();

				vital.PatientId = target.PatientId;
				}

			return Json(new[ ] { vital }.ToDataSourceResult(new DataSourceRequest(), ModelState));
			}

		// Delete vitals for patient detail view template

		public ActionResult Destroy_Vitals(int vitalId)
			{
			var target = GetVitalById(vitalId);
			db.Vitals.Remove(target);
			db.SaveChanges();

			return Json(ModelState.ToDataSourceResult());
			}

		private Vital GetVitalById(int id)
			{
			return db.Vitals.FirstOrDefault(v => v.PatientId == id);
			}

		// GET: Vitals
		public async Task<ActionResult> Index()
			{
			var vitals = db.Vitals.Include(v => v.Patient);
			return View(await vitals.ToListAsync());
			}

		// GET: Vitals/Details/5
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

		// GET: Vitals/Create
		public ActionResult Create()
			{
			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName");
			return View();
			}

		// POST: Vitals/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to, for
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create([Bind(Include = "PatientId,VitalDate,Weight,Height,Temperature,BloodPressure,Pulse,Created,CreatedBy,Modified,ModifiedBy")] Vital vital)
			{
			if (ModelState.IsValid)
				{
				db.Vitals.Add(vital);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
				}

			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix", vital.PatientId);
			return View(vital);
			}

		// GET: Vitals/Edit/5
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
			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix", vital.PatientId);
			return View(vital);
			}

		// POST: Vitals/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to, for
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit([Bind(Include = "PatientId,VitalDate,Weight,Height,Temperature,BloodPressure,Pulse,Created,CreatedBy,Modified,ModifiedBy")] Vital vital)
			{
			if (ModelState.IsValid)
				{
				db.Entry(vital).State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
				}
			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Prefix", vital.PatientId);
			return View(vital);
			}

		// GET: Vitals/Delete/5
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

		// POST: Vitals/Delete/5
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
