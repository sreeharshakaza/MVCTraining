using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo2.Controllers
{
    public class StudetController : Controller
    {
        private MvcDemoEntities db = new MvcDemoEntities();

        //
        // GET: /Studet/

        public ActionResult Index()
        {
            return View(db.Student.ToList());
        }

        //
        // GET: /Studet/Details/5

        public ActionResult Details(int id = 0)
        {
            Student student = db.Student.Single(s => s.Id == id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        //
        // GET: /Studet/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Studet/Create

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Student.AddObject(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        //
        // GET: /Studet/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Student student = db.Student.Single(s => s.Id == id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        //
        // POST: /Studet/Edit/5

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Student.Attach(student);
                db.ObjectStateManager.ChangeObjectState(student, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        //
        // GET: /Studet/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Student student = db.Student.Single(s => s.Id == id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        //
        // POST: /Studet/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Student.Single(s => s.Id == id);
            db.Student.DeleteObject(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}