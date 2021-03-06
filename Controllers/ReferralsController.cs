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
using Microsoft.Ajax.Utilities;

namespace PatientPortalApp.Controllers
	{
	public class ReferralsController : Controller
		{
		private PatientPortalAppContext db = new PatientPortalAppContext();

		public ActionResult Read_Referrals([DataSourceRequest] DataSourceRequest request, int id)
			{
			return Json(db.Referrals.Where(r => r.PatientId == id).ToDataSourceResult(request, r => new Referral()
				{
				ReferralDate = r.ReferralDate,
				ReferralDoctor = r.ReferralDoctor,
				Doctor = r.Doctor,
				Location = r.Location,
				Procedure = r.Procedure,
				CreatedBy = r.CreatedBy
				}));
			}

		public ActionResult Update_Referrals(Referral referral)
			{
			if (referral != null && ModelState.IsValid)
				{
				var target = GetReferralByPatient(referral.PatientId);
				target.ReferralDate = referral.ReferralDate;
				target.Procedure = referral.Procedure;
				target.ReferralDoctor = referral.ReferralDoctor;
				}
			return Json(ModelState.ToDataSourceResult());
			}

		public ActionResult Create_Referral(Referral referral)
			{

			if (referral != null && ModelState.IsValid)
				{
				var target = new Referral();

				target.PatientId = referral.PatientId;
				target.Location = referral.Location;
				target.Doctor = referral.Doctor;
				target.ReferralDoctor = referral.ReferralDoctor;
				target.Procedure = referral.Procedure;
				target.ReferralDate = referral.ReferralDate;

				db.Referrals.Add(target);
				db.SaveChanges();

				referral.PatientId = target.PatientId;
				}
			return Json(new[ ] { referral }.ToDataSourceResult(new DataSourceRequest(), ModelState));
			}

		//[AcceptVerbs("Post")]
		//public ActionResult Destroy_Referral([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<PatientPortalApp.Models.Referral> referrals)
		//	{
		//	try
		//		{
		//		if (referrals.Any())
		//			{
		//			foreach(var referral in referrals)
		//				{
						
		//				}
		//			}
		//		}
		//	catch (Exception e)
		//		{
		//		return Json(e.Message);
		//		}
		//	}

		private Referral GetReferralByPatient(int id)
			{
			return db.Referrals.FirstOrDefault(r => r.PatientId == id);
			}

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
