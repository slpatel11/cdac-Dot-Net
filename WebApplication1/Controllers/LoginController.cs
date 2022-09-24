using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        OapmsEntities dbObj = new OapmsEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn(student loginObject, string ReturnUrl)
        {
            var MatchCount = (from hr in dbObj.students.ToList()
                              where hr.email == loginObject.email
                              && hr.password == loginObject.password
                              select hr).ToList().Count();

            if (MatchCount == 1)
            {

                FormsAuthentication.SetAuthCookie(loginObject.email, false);


                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return Redirect("/Student/Index");
                }
            }
            else
            {
                ViewBag.ErrorMessage = "User Name or Password is incorrect";
                return View();
            }

        }



        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(student studentToBeAdded)
        {
            if (ModelState.IsValid)
            {

                dbObj.students.Add(studentToBeAdded);
                dbObj.SaveChanges();

                return Redirect("/Home/Index");
            }
            else
            {
                return View(studentToBeAdded);
            }
        }
    }
}