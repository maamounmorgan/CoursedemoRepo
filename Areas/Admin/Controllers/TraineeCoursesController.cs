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
    public class TraineeCoursesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/TraineeCourses
        public ActionResult Index()
        {
            return View(db.TraineeCourses.ToList());
        }

        // GET: Admin/TraineeCourses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TraineeCourse traineeCourse = db.TraineeCourses.Find(id);
            if (traineeCourse == null)
            {
                return HttpNotFound();
            }
            return View(traineeCourse);
        }

        // GET: Admin/TraineeCourses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/TraineeCourses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Trainee_Id,Course_Id,RegistrationDate")] TraineeCourse traineeCourse)
        {
            if (ModelState.IsValid)
            {
                db.TraineeCourses.Add(traineeCourse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(traineeCourse);
        }

        // GET: Admin/TraineeCourses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TraineeCourse traineeCourse = db.TraineeCourses.Find(id);
            if (traineeCourse == null)
            {
                return HttpNotFound();
            }
            return View(traineeCourse);
        }

        // POST: Admin/TraineeCourses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Trainee_Id,Course_Id,RegistrationDate")] TraineeCourse traineeCourse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(traineeCourse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(traineeCourse);
        }

        // GET: Admin/TraineeCourses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TraineeCourse traineeCourse = db.TraineeCourses.Find(id);
            if (traineeCourse == null)
            {
                return HttpNotFound();
            }
            return View(traineeCourse);
        }

        // POST: Admin/TraineeCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TraineeCourse traineeCourse = db.TraineeCourses.Find(id);
            db.TraineeCourses.Remove(traineeCourse);
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
