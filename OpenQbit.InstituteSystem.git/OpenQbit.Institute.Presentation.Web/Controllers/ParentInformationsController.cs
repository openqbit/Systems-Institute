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

namespace OpenQbit.Institute.Presentation.Web.Controllers
{
    public class ParentInformationsController : Controller
    {
        private InstituteDbContext db = new InstituteDbContext();

        // GET: ParentInformations
        public ActionResult Index()
        {
            return View(db.ParentInformation.ToList());
        }

        // GET: ParentInformations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentInformation parentInformation = db.ParentInformation.Find(id);
            if (parentInformation == null)
            {
                return HttpNotFound();
            }
            return View(parentInformation);
        }

        // GET: ParentInformations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParentInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ParentInformationId,MotherId,FatherId,PrimaryContactNumber")] ParentInformation parentInformation)
        {
            if (ModelState.IsValid)
            {
                db.ParentInformation.Add(parentInformation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parentInformation);
        }

        // GET: ParentInformations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentInformation parentInformation = db.ParentInformation.Find(id);
            if (parentInformation == null)
            {
                return HttpNotFound();
            }
            return View(parentInformation);
        }

        // POST: ParentInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ParentInformationId,MotherId,FatherId,PrimaryContactNumber")] ParentInformation parentInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parentInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parentInformation);
        }

        // GET: ParentInformations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentInformation parentInformation = db.ParentInformation.Find(id);
            if (parentInformation == null)
            {
                return HttpNotFound();
            }
            return View(parentInformation);
        }

        // POST: ParentInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParentInformation parentInformation = db.ParentInformation.Find(id);
            db.ParentInformation.Remove(parentInformation);
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
