using LeaveSystem.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LeaveSystem.Controllers
{
    public class EmployeeController : Controller
    {
        

        private Context _context;
        public EmployeeController()
        {
            _context = new Context();
        }


        //Release resources....
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }




        //Show details of particular user.....
        [HandleError(View="Error1")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee emp = _context.employees.Find(id);
            if (emp == null)
            {
                throw new Exception();
            }
          
            return View(emp);
        }










        //Add new Employee page.......
        public ActionResult Create()
        {
            return View();
        }


        //Add employee to database......
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "empId,mgrId,fullName,deptName,mailId,contactNo,availLeaves,doj")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }


        //Returns all active Employees......
        public ActionResult Index()
        {
            var employeeList = _context.employees.ToList();
            return View(employeeList);
        }


        //Editing Information page.....
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee emp = _context.employees.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }


        //Updation in the database......
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "empId,mgrId,fullName,deptName,mailId,contactNo,availLeaves,doj")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(employee).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }



        //Delete the employee page....
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee emp = _context.employees.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }


        //Remove Employee from database......
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee emp = _context.employees.Find(id);
            _context.employees.Remove(emp);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }











    }
}