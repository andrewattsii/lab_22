using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_22.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        //this grabs all data  from the form and gives it to a view
        //peramiters take in the info from the form 
        //public ActionResult GetData(string name, string lastName, string email, string phoneNumber, string password)
        //{


        //    //this allows the data to be transferable to another view
        //    ViewBag.name = name;
        //    ViewBag.lastName = lastName;
        //    ViewBag.email = email;
        //    ViewBag.phoneNumber = phoneNumber;
        //    ViewBag.password = password;
        //    //
        //    return View("SummaryPage");
        //}
        //public ActionResult SummaryPage()
        //{
        //    return View();
        //}

        [HttpPost]

        //4 user input goes into the pased in paramiters and parameter has to be exact to the register html so the variables can connect
        //modelsnewuser is based off of NewUser object (the blueprint)
        public ActionResult SummaryPage(string name, string lastName, string email, string phoneNumber, string password)
        {
            Models.NewUser user= new Models.NewUser();
            user.Name = name;
            user.LastName = lastName;
            user.Email = email;
            user.PhoneNumber = phoneNumber;
            user.Password = password;

            return View(user);
        }
    }
}