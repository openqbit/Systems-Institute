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
    public class BranchResourceAllocationsController : Controller
    {
        private InstituteDbContext db = new InstituteDbContext();

        // GET: BranchResourceAllocations
        public ActionResult Index()
        {
            var branchResourceAllocation = db.BranchResourceAllocation.Include(b => b.Branch).Include(b => b.Resource);
            return View(branchResourceAllocation.ToList());
        }

        // GET: BranchResourceAllocations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BranchResourceAllocation branchResourceAllocation = db.BranchResourceAllocation.Find(id);
            if (branchResourceAllocation == null)
            {
                return HttpNotFound();
            }
            return View(branchResourceAllocation);
        }

        // GET: BranchResourceAllocations/Create
        public ActionResult Create()
        {
            ViewBag.BranchId = new SelectList(db.Branch, "BranchId", "BranchName");
            ViewBag.ResourceId = new SelectList(db.Resources, "ResourceID", "ResourceType");
            return View();
        }

        // POST: BranchResourceAllocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BranchResourceAllocationId,BranchId,ResourceId")] BranchResourceAllocation branchResourceAllocation)
        {
            if (ModelState.IsValid)
            {
                db.BranchResourceAllocation.Add(branchResourceAllocation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BranchId = new SelectList(db.Branch, "BranchId", "BranchName", branchResourceAllocation.BranchId);
            ViewBag.ResourceId = new SelectList(db.Resources, "ResourceID", "ResourceType", branchResourceAllocation.ResourceId);
            return View(branchResourceAllocation);
        }

        // GET: BranchResourceAllocations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BranchResourceAllocation branchResourceAllocation = db.BranchResourceAllocation.Find(id);
            if (branchResourceAllocation == null)
            {
                return HttpNotFound();
            }
            ViewBag.BranchId = new SelectList(db.Branch, "BranchId", "BranchName", branchResourceAllocation.BranchId);
            ViewBag.ResourceId = new SelectList(db.Resources, "ResourceID", "ResourceType", branchResourceAllocation.ResourceId);
            return View(branchResourceAllocation);
        }

        // POST: BranchResourceAllocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BranchResourceAllocationId,BranchId,ResourceId")] BranchResourceAllocation branchResourceAllocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(branchResourceAllocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BranchId = new SelectList(db.Branch, "BranchId", "BranchName", branchResourceAllocation.BranchId);
            ViewBag.ResourceId = new SelectList(db.Resources, "ResourceID", "ResourceType", branchResourceAllocation.ResourceId);
            return View(branchResourceAllocation);
        }

        // GET: BranchResourceAllocations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BranchResourceAllocation branchResourceAllocation = db.BranchResourceAllocation.Find(id);
            if (branchResourceAllocation == null)
            {
                return HttpNotFound();
            }
            return View(branchResourceAllocation);
        }

        // POST: BranchResourceAllocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BranchResourceAllocation branchResourceAllocation = db.BranchResourceAllocation.Find(id);
            db.BranchResourceAllocation.Remove(branchResourceAllocation);
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
