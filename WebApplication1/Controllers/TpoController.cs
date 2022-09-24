using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TpoController : Controller
    {
        // GET: Tpo
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tpo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tpo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tpo/Create
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

        // GET: Tpo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tpo/Edit/5
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

        // GET: Tpo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tpo/Delete/5
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
