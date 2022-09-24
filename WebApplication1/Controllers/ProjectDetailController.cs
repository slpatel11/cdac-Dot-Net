using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProjectDetailController : Controller
    {
        // GET: ProjectDetail
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProjectDetail/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProjectDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectDetail/Create
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

        // GET: ProjectDetail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProjectDetail/Edit/5
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

        // GET: ProjectDetail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProjectDetail/Delete/5
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
