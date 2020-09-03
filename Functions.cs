using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System
{
    class Functions
    {

        /*
         * for displaying
         * all employee details.
         */
        public void listAllEmployees()
        {
            Console.WriteLine("Welcome to Listing");
            Employee e = new Employee();
            e.displayAll();

        }



        /*
         * for displaying particular
         * employee details.
         */
        public void listParticularEmployee()
        {
            Console.WriteLine("Enter empid");
            int eid = int.Parse(Console.ReadLine());
            Employee e = new Employee();
            e.displayParticular(eid);
        }




        /* for add or
         * register new Employee
         * in record
        */
        public void addEmployeeDetails()
        {
            int empid, mgrid;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Employee id");
                    empid = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Manager id");
                    mgrid = int.Parse(Console.ReadLine());

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter id in correct Format");
                }
            }


            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Department Name");
            string dept = Console.ReadLine();

            Console.WriteLine("Enter Mail id");
            string mail = Console.ReadLine();

            Console.WriteLine("Enter Contact Number");
            double contact = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Available Leaves");
            int availleaves = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date of Joining");
            DateTime doj = DateTime.Parse(Console.ReadLine());

            Employee e = new Employee(empid, mgrid, name, dept, mail, contact, availleaves, doj);
            e.add(e);

        }






        /* Leave Class Methods
         * addLeave
         * displayLeave
         */

        public void addLeave()
        {
            Console.WriteLine("Enter Empid you want to apply for leave");
            int eid = int.Parse(Console.ReadLine());
            Employee e = new Employee();
            bool res = e.check(eid);

            if (res == true)
            {
                Console.WriteLine("Enter Leave id");
                int lid = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Start Date");
                DateTime sdate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter End Date");
                DateTime edate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter Number of Leaves");
                int lDays = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Leave Type");
                string lType = Console.ReadLine();

                Console.WriteLine("Enter Leave Status");
                string lStatus = Console.ReadLine();

                Console.WriteLine("Enter Leave Reason");
                string lReason = Console.ReadLine();

                DateTime todayDate = new DateTime();

                Leave l = new Leave(lid, eid, sdate, edate, lDays, todayDate, lType, lReason, lStatus);
                l.add(l);
            }

            else
            {
                Console.WriteLine("Employee not exist");
            }
        }


        public void listAllLeaves()
        {
            Console.WriteLine("Welcome to Listing");
            Leave e = new Leave();
            e.displayAllLeaves();

        }

    }
}