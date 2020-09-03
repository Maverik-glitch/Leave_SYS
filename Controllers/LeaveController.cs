using LeaveSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LeaveSystem.Controllers
{
   public class LeaveController : Controller
    {
        private Context _context;
        public LeaveController()
        {
            _context = new Context();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Apply([Bind(Include = "leaveId,leaveFrom,leaveTo,leaveNdays,leaveApplyDate,leaveType,leaveReason,lStatus,empId")] Leave leave)
        {
            if (ModelState.IsValid)
            {
                _context.leaves.Add(leave);
                _context.SaveChanges();

                Employee emp = _context.employees.Find(leave.empId);
                emp.availLeaves = emp.availLeaves - leave.leaveNdays;
                _context.Entry(emp).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index","Employee");
            }

         
            return View(leave);
            
        }



        [HandleError(View="Error")]
        public ActionResult LeaveDetails(int ?id)
        {
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var l = _context.leaves.Where(c => c.empId == id).ToList();

            
            if (l.Count()==0)
            {
                throw new Exception();
            }
            return View(l);
        }
    }
}