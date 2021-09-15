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
	public class AppointmentsController : Controller
		{


		private PatientPortalAppContext db = new PatientPortalAppContext();

		public ActionResult Read_Appointment([DataSourceRequest] DataSourceRequest request, int id)
			{
			var appoinments = db.Appoinments.Include(a => a.Patient).Include(a => a.Provider);

			return Json(appoinments.Where(a => a.PatientId == id).ToDataSourceResult(request, a => new Appointment()
				{
				AppointmentDate = a.AppointmentDate,
				ProviderName = a.ProviderName,
				Reason = a.Reason,
				PatientId = a.PatientId,
				ProviderId = a.ProviderId,
				HasBalance = a.HasBalance
				}));
			}

		public ActionResult Read_Appointments([DataSourceRequest] DataSourceRequest request, int id)
			{
			var provider = db.Providers.Include(p => p.ProviderName);
			return Json(db.Appoinments.Where(a => a.PatientId == id).ToDataSourceResult(request, a => new Appointment()
				{
				AppointmentDate = a.AppointmentDate,
				Reason = a.Reason,
				PatientId = a.PatientId,
				ProviderId = a.ProviderId,
				HasBalance = a.HasBalance,
				ProviderName = a.Provider.ProviderName
				}), JsonRequestBehavior.AllowGet);
			}

		public ActionResult Update_Appointment(Appointment appointment)
			{
			if (appointment != null && ModelState.IsValid)
				{
				var target = GetAppointmentByPatientId(appointment.PatientId);
				target.PatientId = appointment.PatientId;
				target.Patient.FirstName = appointment.Patient.FirstName;
				target.Patient.LastName = appointment.Patient.LastName;
				target.AppointmentDate = appointment.AppointmentDate;
				target.Reason = appointment.Reason;
				target.ProviderId = appointment.ProviderId;
				db.SaveChanges();
				}
			return Json(ModelState.ToDataSourceResult());
			}
		public ActionResult Create_Appointment(Appointment appointment)
			{
			if (appointment != null && ModelState.IsValid)
				{
				var target = GetAppointmentByPatientId(appointment.PatientId);
				target.PatientId = appointment.PatientId;
				target.Patient.FirstName = appointment.Patient.FirstName;
				target.Patient.LastName = appointment.Patient.LastName;
				target.AppointmentDate = appointment.AppointmentDate;
				target.Reason = appointment.Reason;
				target.ProviderId = appointment.ProviderId;
				db.SaveChanges();
				}
			return Json(ModelState.ToDataSourceResult());
			}

		private Appointment GetAppointmentByPatientId(int id)
			{
			return db.Appoinments.FirstOrDefault(a => a.PatientId == id);
			}

		private Appointment GetAppointmentByProviderId(int id)
			{
			return db.Appoinments.FirstOrDefault(a => a.ProviderId == id);
			}

		// GET: Appointments
		public async Task<ActionResult> Index()
			{
			var appoinments = db.Appoinments.Include(a => a.Patient).Include(a => a.Provider);
			return View(await appoinments.ToListAsync());
			}

		// GET: Appointments/Details/5
		public async Task<ActionResult> Details(int? id)
			{
			if (id == null)
				{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
				}
			Appointment appointment = await db.Appoinments.FindAsync(id);
			if (appointment == null)
				{
				return HttpNotFound();
				}
			return View(appointment);
			}

		// GET: Appointments/Create
		public ActionResult Create()
			{
			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Ssn");
			ViewBag.ProviderId = new SelectList(db.Providers, "ProviderId", "ProviderName");
			return View();
			}

		// POST: Appointments/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to, for
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create([Bind(Include = "PatientId,AppointmentDate,CreatedBy,Created,ModifiedBy,Modified,Reason,ProviderId")] Appointment appointment)
			{
			if (ModelState.IsValid)
				{
				db.Appoinments.Add(appointment);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
				}

			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Ssn", appointment.PatientId);
			ViewBag.ProviderId = new SelectList(db.Providers, "ProviderId", "ProviderName", appointment.ProviderId);
			return View(appointment);
			}

		// GET: Appointments/Edit/5
		public async Task<ActionResult> Edit(int? id)
			{
			if (id == null)
				{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
				}
			Appointment appointment = await db.Appoinments.FindAsync(id);
			if (appointment == null)
				{
				return HttpNotFound();
				}
			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "Ssn", appointment.PatientId);
			ViewBag.ProviderId = new SelectList(db.Providers, "ProviderId", "ProviderName", appointment.ProviderId);
			return View(appointment);
			}

		// POST: Appointments/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to, for
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit([Bind(Include = "PatientId,AppointmentDate,CreatedBy,Created,ModifiedBy,Modified,Reason,ProviderId")] Appointment appointment)
			{
			if (ModelState.IsValid)
				{
				db.Entry(appointment).State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
				}
			ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName", appointment.PatientId);
			ViewBag.ProviderId = new SelectList(db.Providers, "ProviderId", "ProviderName", appointment.ProviderId);
			return View(appointment);
			}

		// GET: Appointments/Delete/5
		public async Task<ActionResult> Delete(int? id)
			{
			if (id == null)
				{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
				}
			Appointment appointment = await db.Appoinments.FindAsync(id);
			if (appointment == null)
				{
				return HttpNotFound();
				}
			return View(appointment);
			}

		// POST: Appointments/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(int id)
			{
			Appointment appointment = await db.Appoinments.FindAsync(id);
			db.Appoinments.Remove(appointment);
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
