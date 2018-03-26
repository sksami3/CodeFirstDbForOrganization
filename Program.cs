using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Con.Model;

namespace Test.Con
{
    class Program
    {
        static void Main(string[] args)
        {
            OrganizationsDbContext db = new OrganizationsDbContext();
            Employee employee3 = new Employee();
            employee3.name = "sa";
            db.employee.Add(employee3);
            db.SaveChanges();

            foreach (var item in db.employee)
            {
                Console.WriteLine("{0}", item.name);

            }

            Admin admin1 = new Admin();
            admin1.name = "admin1";
            db.admin.Add(admin1);
            db.SaveChanges();

            foreach (var item in db.admin)
            {
                Console.WriteLine("{0}", item.name);

            }

            Organization organization = new Organization();
            organization.name = "aiub";

            
            organization.admin_id = 2;
            //organization.employee_id = 1;
            //organization.admin.admin_id = 1;
            //organization.admin = admin1;
            organization.employee = new List<Employee>() { new Employee { name = "sami" }, new Employee { name="moja" } };
            db.organization.Add(organization);
            db.SaveChanges();

            foreach (var item in db.organization)
            {
                Console.WriteLine("{0} {1} {2}", item.name, item.admin_id, item.employee_id);

            }
        }
    }
}
