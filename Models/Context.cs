using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LeaveSystem.Models
{
    public class Context: DbContext
    {
        public Context(): base("cs3") { }

        public DbSet<Employee> employees { get; set; }

        public DbSet<Leave> leaves { get; set; }

        public DbSet<User> users { get; set; }
    }
}