using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBProject.Controllers
{
    public class HomeController : Controller
    {
        private Models.DatabaseEntities db = new Models.DatabaseEntities();
        // GET: DataBase
        public ActionResult Index()
        {
            return View(db.Odbiorcy.ToList());
        }

        // GET: DataBase/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        // GET: DataBase/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "ID")] Models.Odbiorcy odbiorcaToAdd)
        {
            if (!ModelState.IsValid)
                return View();

            db.Odbiorcy.Add(odbiorcaToAdd);
            db.SaveChanges();

            return RedirectToAction("index");
        }




        // GET: DataBase/Edit/5
        public ActionResult Edit(int id)
        {
            var odbiorcaToEdit = (from o in db.Odbiorcy
                                  where o.Id == id
                                  select o).First();
            return View(odbiorcaToEdit);
        }

        // POST: DataBase/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DataBase/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DataBase/Delete/5
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
