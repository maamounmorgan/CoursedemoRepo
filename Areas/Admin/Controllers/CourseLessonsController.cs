using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CourseDemo.Models;

namespace CourseDemo.Areas.Admin.Controllers
{
    public class CourseLessonsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/CourseLessons
        public ActionResult Index()
        {
            var courseLessons = db.CourseLessons.Include(c => c.Course);
            return View(courseLessons.ToList());
        }

        // GET: Admin/CourseLessons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseLesson courseLesson = db.CourseLessons.Find(id);
            if (courseLesson == null)
            {
                return HttpNotFound();
            }
            return View(courseLesson);
        }

        // GET: Admin/CourseLessons/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name");
            return View();
        }

        // POST: Admin/CourseLessons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,OrderNumber,CourseId")] CourseLesson courseLesson)
        {
            if (ModelState.IsValid)
            {
                db.CourseLessons.Add(courseLesson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", courseLesson.CourseId);
            return View(courseLesson);
        }

        // GET: Admin/CourseLessons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseLesson courseLesson = db.CourseLessons.Find(id);
            if (courseLesson == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", courseLesson.CourseId);
            return View(courseLesson);
        }

        // POST: Admin/CourseLessons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,OrderNumber,CourseId")] CourseLesson courseLesson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseLesson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", courseLesson.CourseId);
            return View(courseLesson);
        }

        // GET: Admin/CourseLessons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseLesson courseLesson = db.CourseLessons.Find(id);
            if (courseLesson == null)
            {
                return HttpNotFound();
            }
            return View(courseLesson);
        }

        // POST: Admin/CourseLessons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseLesson courseLesson = db.CourseLessons.Find(id);
            db.CourseLessons.Remove(courseLesson);
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
