using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstDemo
{
    public class EmployeeDbContext : DbContext
    {

        public EmployeeDbContext() : base("cs1") { }

        public DbSet<Employee> Employees { get; set; }
    }
}