using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveSystem.Controllers
{
    public class ErrorController : Controller
    {
        //Handle 404 error......
        public ActionResult NotFound()
        {
            return View();
        }
    }
}