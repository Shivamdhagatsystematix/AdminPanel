using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCUserRoles.Models;

namespace MVCUserRoles.Controllers
{
    public class AddRemoveTeachersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AddRemoveTeachers
        public ActionResult Index()
        {
            return View(db.AddRemoveTeacher.ToList());
        }

        // GET: AddRemoveTeachers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddRemoveTeachers addRemoveTeachers = db.AddRemoveTeacher.Find(id);
            if (addRemoveTeachers == null)
            {
                return HttpNotFound();
            }
            return View(addRemoveTeachers);
        }

        // GET: AddRemoveTeachers/Create
        public ActionResult Create()
        {

            ViewBag.CourseName = new SelectList(db.Courses.Where(u => !u.CourseName.Contains("Admin"))
                .ToList(), "CourseName", "CourseName");
            return View();
        }


        // POST: AddRemoveTeachers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TeacherId,TeacherName,SubjectAssign,City,Address")] AddRemoveTeachers addRemoveTeachers)
        {
            if (ModelState.IsValid)
            {
                db.AddRemoveTeacher.Add(addRemoveTeachers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addRemoveTeachers);
        }

        // GET: AddRemoveTeachers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddRemoveTeachers addRemoveTeachers = db.AddRemoveTeacher.Find(id);
            if (addRemoveTeachers == null)
            {
                return HttpNotFound();
            }
            return View(addRemoveTeachers);
        }

        // POST: AddRemoveTeachers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TeacherId,TeacherName,SubjectAssign,City,Address")] AddRemoveTeachers addRemoveTeachers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addRemoveTeachers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addRemoveTeachers);
        }

        // GET: AddRemoveTeachers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddRemoveTeachers addRemoveTeachers = db.AddRemoveTeacher.Find(id);
            if (addRemoveTeachers == null)
            {
                return HttpNotFound();
            }
            return View(addRemoveTeachers);
        }

        // POST: AddRemoveTeachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AddRemoveTeachers addRemoveTeachers = db.AddRemoveTeacher.Find(id);
            db.AddRemoveTeacher.Remove(addRemoveTeachers);
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
