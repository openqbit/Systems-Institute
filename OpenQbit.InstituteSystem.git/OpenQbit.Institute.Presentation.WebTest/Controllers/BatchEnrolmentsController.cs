using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OpenQbit.Institute.Common.Models;
using OpenQbit.Institute.DAL.DataAccess;

namespace OpenQbit.Institute.Presentation.WebTest.Controllers
{
    public class BatchEnrolmentsController : Controller
    {
        private InstituteDbContext db = new InstituteDbContext();

        // GET: BatchEnrolments
        public ActionResult Index()
        {
            var batchEnrolment = db.BatchEnrolment.Include(b => b.Batch).Include(b => b.Student);
            return View(batchEnrolment.ToList());
        }

        // GET: BatchEnrolments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BatchEnrolment batchEnrolment = db.BatchEnrolment.Find(id);
            if (batchEnrolment == null)
            {
                return HttpNotFound();
            }
            return View(batchEnrolment);
        }

        // GET: BatchEnrolments/Create
        public ActionResult Create()
        {
            ViewBag.BatchId = new SelectList(db.Batch, "BatchId", "BatchName");
            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "StudentName");
            return View();
        }

        // POST: BatchEnrolments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BatchEnrolmentId,TimeDuration,BatchId,StudentId")] BatchEnrolment batchEnrolment)
        {
            if (ModelState.IsValid)
            {
                db.BatchEnrolment.Add(batchEnrolment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BatchId = new SelectList(db.Batch, "BatchId", "BatchName", batchEnrolment.BatchId);
            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "StudentName", batchEnrolment.StudentId);
            return View(batchEnrolment);
        }

        // GET: BatchEnrolments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BatchEnrolment batchEnrolment = db.BatchEnrolment.Find(id);
            if (batchEnrolment == null)
            {
                return HttpNotFound();
            }
            ViewBag.BatchId = new SelectList(db.Batch, "BatchId", "BatchName", batchEnrolment.BatchId);
            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "StudentName", batchEnrolment.StudentId);
            return View(batchEnrolment);
        }

        // POST: BatchEnrolments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BatchEnrolmentId,TimeDuration,BatchId,StudentId")] BatchEnrolment batchEnrolment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(batchEnrolment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BatchId = new SelectList(db.Batch, "BatchId", "BatchName", batchEnrolment.BatchId);
            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "StudentName", batchEnrolment.StudentId);
            return View(batchEnrolment);
        }

        // GET: BatchEnrolments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BatchEnrolment batchEnrolment = db.BatchEnrolment.Find(id);
            if (batchEnrolment == null)
            {
                return HttpNotFound();
            }
            return View(batchEnrolment);
        }

        // POST: BatchEnrolments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BatchEnrolment batchEnrolment = db.BatchEnrolment.Find(id);
            db.BatchEnrolment.Remove(batchEnrolment);
            db.SaveChanges();
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
