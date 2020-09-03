using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Leave_Management_System;

namespace Leave_Management_System.Test
{
    [TestFixture]
    public class EmployeeTest
    {

        /*
         test for accessor and mutators
         */
        [Test]
        public void Whether_getter_setter_is_working_correctly()
        {
            Employee e = new Employee();
            e.EmpId = 12;
            e.MgrId = 14;
            e.FullName = "Pratham";
            e.MailId = "pra@gmail.com";
            e.DeptName = "debugger";
            e.ContactNo = 2145452345;
            e.AvailLeaves = 14;
            e.DateJoining = DateTime.Parse("1/2/2020 12:23:12 AM");

            Assert.AreEqual(e.EmpId, 12);
            Assert.AreEqual(e.MgrId, 14);
            Assert.AreEqual(e.FullName, "Pratham");
            Assert.AreEqual(e.MailId, "pra@gmail.com");
            Assert.AreEqual(e.DeptName, "debugger");
            Assert.AreEqual(e.ContactNo, 2145452345);
            Assert.AreEqual(e.AvailLeaves, 14);
            Assert.AreEqual(e.DateJoining, DateTime.Parse("1/2/2020 12:23:12 AM"));

        }



        /*
         * test for parametric constructor.
         */
        [Test]
        public void Whether_Parameterized_Constructor_is_working_correctly()
        {
            Employee e = new Employee(1, 2, "Sharma", "software", "sh@gmail.com", 7856342345, 12, DateTime.Parse("1/2/2020 12:23:12 AM"));
            Assert.AreEqual(e.EmpId, 1);
            Assert.AreEqual(e.DeptName, "software");
            Assert.AreEqual(e.ContactNo, 7856342345);
            Assert.AreEqual(e.AvailLeaves, 12);
        }




    }

}
