using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TechnicalDetailController : Controller
    {
        // GET: TechnicalDetail
        public ActionResult Index()
        {
            return View();
        }

        // GET: TechnicalDetail/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TechnicalDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TechnicalDetail/Create
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

        // GET: TechnicalDetail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TechnicalDetail/Edit/5
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

        // GET: TechnicalDetail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TechnicalDetail/Delete/5
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
