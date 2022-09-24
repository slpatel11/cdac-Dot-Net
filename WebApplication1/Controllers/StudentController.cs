using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        OapmsEntities dbObj = new OapmsEntities();
        // GET: Student
        public ActionResult Index()
        {

            ViewBag.MyTitle = "studentlist";


            var all = dbObj.students.ToList();
            return View(all);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult ProjectDetails()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult ProjectDetails(projectDetail pd)
        {
            dbObj.projectDetails.Add(pd);
            dbObj.SaveChanges();

            return Redirect("/Home/Index");
        }

        // GET: Student/Create
        public ActionResult TechDetails()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult TechDetails(technical tec)
        {
            dbObj.technicals.Add(tec);
            dbObj.SaveChanges();

            return Redirect("/Home/Index");
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Message = "Please Update student Here!";
            ViewBag.UserName = User.Identity.Name;

            student studentToBeEdited = (from p in dbObj.students.ToList()
                                       where p.studentId == id
                                       select p).First();

            return View(studentToBeEdited);
            
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(student studentUpdated)
        {
            
            {
                var v = ViewBag.Message;
                student studentToBeEdited = (from p in dbObj.students.ToList()
                                           where p.studentId == studentUpdated.studentId
                                           select p).First();

                studentToBeEdited.name = studentUpdated.name;
                studentToBeEdited.phone = studentUpdated.phone;
                studentToBeEdited.email = studentUpdated.email;
                studentToBeEdited.address = studentUpdated.address;
                dbObj.SaveChanges();
                //This will update the database

                return Redirect("/Home/Index");

            }
            
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
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
