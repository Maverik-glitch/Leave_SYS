using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveSystem.Controllers
{

    public class HomeController : Controller
    {
        //Home page....
        public ActionResult Index()
        {
            return View();
        }



        //Testimonial page....
        public ActionResult Testimonials()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        //Contact page......
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        //About page......
        public ActionResult About()
        {
            return View();
        }
    }
}