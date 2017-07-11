using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OpenQbit.Institute.Presentation.Web.Models;
using OpenQbit.Institute.Presentation.Web.Models.Branch;

namespace OpenQbit.Institute.Presentation.Web.Controllers
{
    public class BranchItemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BranchItems
        public ActionResult Index()
        {
            return View(db.BranchItems.ToList());
        }

        // GET: BranchItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BranchItem branchItem = db.BranchItems.Find(id);
            if (branchItem == null)
            {
                return HttpNotFound();
            }
            return View(branchItem);
        }

        // GET: BranchItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BranchItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,BranchName,Address,Email,TelephoneNo,ParentInformationID")] BranchItem branchItem)
        {
            if (ModelState.IsValid)
            {
                db.BranchItems.Add(branchItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(branchItem);
        }

        // GET: BranchItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BranchItem branchItem = db.BranchItems.Find(id);
            if (branchItem == null)
            {
                return HttpNotFound();
            }
            return View(branchItem);
        }

        // POST: BranchItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,BranchName,Address,Email,TelephoneNo,ParentInformationID")] BranchItem branchItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(branchItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(branchItem);
        }

        // GET: BranchItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BranchItem branchItem = db.BranchItems.Find(id);
            if (branchItem == null)
            {
                return HttpNotFound();
            }
            return View(branchItem);
        }

        // POST: BranchItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BranchItem branchItem = db.BranchItems.Find(id);
            db.BranchItems.Remove(branchItem);
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
