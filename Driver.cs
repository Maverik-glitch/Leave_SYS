using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Leave_Management_System
{


    /*
      Class which initiating
      our project.
    */
    class Driver
    {
        Functions f = new Functions();



        /*
         mainmenu()  method consisting
         the functionality of Project.
        */
        private void mainMenu()
        {
            Console.WriteLine("Leave Management System");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Add Employee Details");
            Console.WriteLine("2. List All Employees");
            Console.WriteLine("3. List Particular Employee");
            Console.WriteLine("4. Add Leave For Employee");
            Console.WriteLine("5. List All Leaves Applied by Employees");

            Console.WriteLine("6. Exit");
            Console.WriteLine("Enter your choice ");

            int menuOption = int.Parse(Console.ReadLine());
            mainMenuDetails(menuOption);
        }



        /* Switch Cases for
           calling specific functionality
           of project.
         */
        private void mainMenuDetails(int selectedOption)
        {
            switch (selectedOption)
            {

                case 1:
                    {
                        f.addEmployeeDetails();
                        break;
                    }
                case 2:
                    {
                        f.listAllEmployees();
                        break;
                    }
                case 3:
                    {
                        f.listParticularEmployee();
                        break;
                    }

                case 4:
                    {
                        f.addLeave();
                        break;
                    }

                case 5:
                    {
                        f.listAllLeaves();
                        break;
                    }

                case 6:
                    {
                        Environment.Exit(0);
                        break;
                    }

            }
            mainMenu();
        }




        /* Login method for logging
           into our project.
         */
        private void login()
        {
            Console.WriteLine("Enter user name");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            if (username.Equals("pratham") && password.Equals("#23*"))
            {
                Console.WriteLine("You are successfully logged in");
                mainMenu();
            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
            }
            Console.ReadLine();
        }




        /*
          Main method which is starting
          point of program.
         */
        static void Main(string[] args)
        {
            Driver pi = new Driver();
            pi.login();
        }


    }

}