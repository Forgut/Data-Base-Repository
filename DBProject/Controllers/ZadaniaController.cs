using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBProject.Controllers
{
    public class ZadaniaController : Controller
    {
        private Models.DatabaseEntities db = new Models.DatabaseEntities();
        // GET: Zadania
        public ActionResult Index()
        {
            return View(db.Zadania.ToList());
        }

        // GET: Zadania/Details/5
        public ActionResult Details(int id)
        {
            var zadanieToViewDetails = (from z in db.Zadania
                                        where z.Id == id
                                        select z).First();
            return View(zadanieToViewDetails);
        }

        // GET: Zadania/Create
        public ActionResult Create()
        {
            return View(new Models.Zadania());
        }

        // POST: Zadania/Create
        [HttpPost]
        public ActionResult Create(Models.Zadania zadanieToAdd)
        {
            if (!ModelState.IsValid)
                return View();

            db.Zadania.Add(zadanieToAdd);
            db.SaveChanges();

            return RedirectToAction("index");
        }

        // GET: Zadania/Edit/5
        public ActionResult Edit(int id)
        {
            var ZadanieToEdit = (from z in db.Zadania
                                 where z.Id == id
                                 select z).First();
            return View(ZadanieToEdit);
        }

        // POST: Zadania/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Zadania zadanieToEdit)
        {
            var originalZadanie = (from z in db.Zadania
                                   where z.Id == zadanieToEdit.Id
                                   select z).First();

            if (!ModelState.IsValid)
                return View(originalZadanie);

            db.Entry(originalZadanie).CurrentValues.SetValues(zadanieToEdit);
            db.SaveChanges();

            return RedirectToAction("index");
        }

        // GET: Zadania/Delete/5
        public ActionResult Delete(int id)
        {
            var zadanieToDelete = (from z in db.Zadania
                                   where z.Id == id
                                   select z).First();

            db.Zadania.Remove(zadanieToDelete);
            db.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
