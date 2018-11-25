using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBProject.Controllers
{
    public class ZamowieniaController : Controller
    {
        private Models.DatabaseEntities db = new Models.DatabaseEntities();
        // GET: Zamowienia
        public ActionResult Index()
        {
            return View(db.Zamówienia);
        }

        // GET: Zamowienia/Details/5
        public ActionResult Details(int id)
        {
            var zamowienieToViewDetails = (from z in db.Zamówienia
                                           where z.Id == id
                                           select z).FirstOrDefault();
            return View(zamowienieToViewDetails);
        }

        // GET: Zamowienia/Create
        public ActionResult Create()
        {
            return View(new Models.Zamówienia());
        }

        // POST: Zamowienia/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "ID")] Models.Zamówienia zamowienieToAdd)
        {
            if (!ModelState.IsValid)
                return View();

            db.Zamówienia.Add(zamowienieToAdd);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Zamowienia/Edit/5
        public ActionResult Edit(int id)
        {
            var zamowienieToEdit = (from z in db.Zamówienia
                                    where z.Id == id
                                    select z).First();
            return View(zamowienieToEdit);
        }

        // POST: Zamowienia/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Zamówienia zamowienieToEdit)
        {
            var originalZamowienie = (from z in db.Zamówienia
                                      where z.Id == zamowienieToEdit.Id
                                      select z).First();
            if (!ModelState.IsValid)
                return View(originalZamowienie);

            db.Entry(originalZamowienie).CurrentValues.SetValues(zamowienieToEdit);
            db.SaveChanges();

            return RedirectToAction("index");
        }

        // GET: Zamowienia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Zamowienia/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
