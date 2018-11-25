using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBProject.Controllers
{
    public class PracownicyController : Controller
    {
        // GET: Pracownicy
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pracownicy/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pracownicy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pracownicy/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pracownicy/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pracownicy/Edit/5
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

        // GET: Pracownicy/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pracownicy/Delete/5
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
