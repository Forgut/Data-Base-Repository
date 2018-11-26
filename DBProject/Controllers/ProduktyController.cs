using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBProject.Controllers
{
    public class ProduktyController : Controller
    {
        Models.DatabaseEntities db = new Models.DatabaseEntities();
        // GET: Produkty
        public ActionResult Index()
        {
            return View(db.Produkty);
        }

        // GET: Produkty/Details/5
        public ActionResult Details(int id)
        {
            var produktToViewDetails = (from p in db.Produkty
                                        where p.Id == id
                                        select p).First();
            return View(produktToViewDetails);
        }

        // GET: Produkty/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produkty/Create
        [HttpPost]
        public ActionResult Create(Models.Produkty produktToCreate)
        {
            if (!ModelState.IsValid)
                return View();

            db.Produkty.Add(produktToCreate);
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                ViewBag.Exception = e.InnerException.InnerException.Message;
                return View();
            }

            return RedirectToAction("index");
        }

        // GET: Produkty/Edit/5
        public ActionResult Edit(int id)
        {
            var produktToEdit = (from p in db.Produkty
                                 where p.Id == id
                                 select p).First();
            return View(produktToEdit);
        }

        // POST: Produkty/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Produkty produktToEdit)
        {
            var originalProdukt = (from p in db.Produkty
                                   where p.Id == produktToEdit.Id
                                   select p).First();
            if (!ModelState.IsValid)
                return View(originalProdukt);

            db.Entry(originalProdukt).CurrentValues.SetValues(produktToEdit);
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                ViewBag.Exception = e.InnerException.InnerException.Message;
                return View(produktToEdit);
            }

            return RedirectToAction("index");
        }

        // GET: Produkty/Delete/5
        public ActionResult Delete(int id)
        {
            var produktToDelete = (from p in db.Produkty
                                   where p.Id == id
                                   select p).First();
            db.Produkty.Remove(produktToDelete);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public  ActionResult AddIngriedientToProduct(int id)
        {
            return View(new Models.potrzebny_do_produkcji() { ID_produktu = id});
        }

        [HttpPost]
        public ActionResult AddIngriedientToProduct(Models.potrzebny_do_produkcji potrzebny)
        {
            if (!ModelState.IsValid)
                return View(potrzebny);

            db.potrzebny_do_produkcji.Add(potrzebny);
            db.SaveChanges();
            try
            {
                db.SaveChanges();
            }
            catch(Exception e)
            {
                ViewBag.Exception = e.InnerException.InnerException.Message;
            }

            return RedirectToAction("index");
        }
    }
}
