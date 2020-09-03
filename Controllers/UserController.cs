using LeaveSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveSystem.Controllers
{
    public class UserController : Controller
    {

        private Context _context = new Context();
        
        public ActionResult Index()
        {
            return View();
        }


        //Calling register page.....
        
        public ActionResult Register()
        {
            return View();
        }


        //Register the user......
        [HttpPost]
       
        public ActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                _context.users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login", "User");
            }

            return View(user);
        }


        //Calling the Login page.....
        public ActionResult Login()
        {
            return View();
        }


        //Validating the user....
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(User user)
        {
            if(!ModelState.IsValid)
            {
                var obj = _context.users.Where(u => (u.username.Equals(user.username) && 
                u.password.Equals(user.password))).SingleOrDefault();
                if (obj != null)
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            return View(user);        
        }

    }
}