using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheNuggetList.Domain.Nuggets;
using TheNuggetList.Data;

namespace TheNuggetList.Controllers
{
    public class HomeController : Controller
    {
        private NuggetDbContext db = new NuggetDbContext();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(db.Nuggets.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id = 0)
        {
            Nugget nugget = db.Nuggets.Find(id);
            if (nugget == null)
            {
                return HttpNotFound();
            }
            return View(nugget);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(Nugget nugget)
        {
            if (ModelState.IsValid)
            {
                db.Nuggets.Add(nugget);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nugget);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Nugget nugget = db.Nuggets.Find(id);
            if (nugget == null)
            {
                return HttpNotFound();
            }
            return View(nugget);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(Nugget nugget)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nugget).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nugget);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Nugget nugget = db.Nuggets.Find(id);
            if (nugget == null)
            {
                return HttpNotFound();
            }
            return View(nugget);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Nugget nugget = db.Nuggets.Find(id);
            db.Nuggets.Remove(nugget);
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