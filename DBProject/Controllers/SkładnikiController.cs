using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBProject.Controllers
{
    public class SkładnikiController : Controller
    {
        private Models.DatabaseEntities db = new Models.DatabaseEntities();
        // GET: Składniki
        public ActionResult Index()
        {
            return View(db.Składniki.ToList());
        }

        // GET: Składniki/Details/5
        public ActionResult Details(int id)
        {
            var SkładnikToViewDetails = (from s in db.Składniki
                                         where s.Id == id
                                         select s).First();
            return View(SkładnikToViewDetails);
        }

        // GET: Składniki/Create
        public ActionResult Create()
        {
            return View(new Models.Składniki());
        }

        // POST: Składniki/Create
        [HttpPost]
        public ActionResult Create(Models.Składniki składnikToCreate)
        {
            if (!ModelState.IsValid)
                return View();

            db.Składniki.Add(składnikToCreate);
            db.SaveChanges();

            return RedirectToAction("index");
        }

        // GET: Składniki/Edit/5
        public ActionResult Edit(int id)
        {
            var składnikToEdit = (from s in db.Składniki
                                  where s.Id == id
                                  select s).First();
            return View(składnikToEdit);
        }

        // POST: Składniki/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Składniki składnikToEdit)
        {
            var originalSkładnik = (from s in db.Składniki
                                    where s.Id == składnikToEdit.Id
                                    select s).First();

            if (!ModelState.IsValid)
                return View(originalSkładnik);

            db.Entry(originalSkładnik).CurrentValues.SetValues(składnikToEdit);
            db.SaveChanges();

            return RedirectToAction("index");
        }

        // GET: Składniki/Delete/5
        public ActionResult Delete(int id)
        {
            var składnikToDelete = (from s in db.Składniki
                                    where s.Id == id
                                    select s).First();
            db.Składniki.Remove(składnikToDelete);
            db.SaveChanges();

            return RedirectToAction("index");
        }

        
    }
}
