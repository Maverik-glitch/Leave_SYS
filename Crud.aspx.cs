using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstDemo
{
    public partial class Crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)   //for inserting
        {
            Employee e1 = new Employee();
            //e1.Id = int.Parse(TextBox1.Text);
            e1.FirstName = TextBox2.Text;
            e1.LastName = TextBox3.Text;
            e1.Gender = TextBox4.Text;
            e1.Salary = int.Parse(TextBox5.Text);

            EmployeeDbContext _context = new EmployeeDbContext();
            _context.Employees.Add(e1);
            _context.SaveChanges();

            BindGridView();
        }

        public void BindGridView()
        {
            EmployeeDbContext _context = new EmployeeDbContext();
            GridView1.DataSource = _context.Employees.ToList();
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)// for deleting
        {
            EmployeeDbContext _context = new EmployeeDbContext();
            Int64 id = Convert.ToInt64(TextBox6.Text);
            Employee e2 = _context.Employees.SingleOrDefault(x => x.Id == id);
            _context.Employees.Remove(e2);
            _context.SaveChanges();
            BindGridView();

        }

        protected void Button3_Click(object sender, EventArgs e)//Update
        {
            EmployeeDbContext _context = new EmployeeDbContext();
            Int64 id = Convert.ToInt64(TextBox7.Text);
            string FirstName = TextBox8.Text;
            string LastName = TextBox9.Text;
            string Gender = TextBox10.Text;
            int salary = int.Parse(TextBox11.Text);

            Employee e2 = _context.Employees.SingleOrDefault(x => x.Id == id);
             e2.FirstName = FirstName;
             e2.LastName = LastName;
             e2.Gender = Gender;
            e2.Salary = salary;

            _context.SaveChanges();

            BindGridView();

        }
    }

}