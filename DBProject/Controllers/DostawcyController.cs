using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBProject.Controllers
{
    public class DostawcyController : Controller
    {
        // GET: Dostawcy
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dostawcy/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dostawcy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dostawcy/Create
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

        // GET: Dostawcy/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dostawcy/Edit/5
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

        // GET: Dostawcy/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dostawcy/Delete/5
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
