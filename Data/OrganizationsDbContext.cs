using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Test.Con.Model;

namespace Test.Con
{

    public class OrganizationsDbContext : DbContext
    {
        //public StudentsDbContext(): base("StudentsDbConnectionString")
        //{
        //}
        public DbSet<Employee> employee { set; get; }
        public DbSet<Admin> admin { set; get; }
        public DbSet<Organization> organization { set; get; }
        
    }
}
