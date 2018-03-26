using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Con.Model
{
    public class Organization
    {
        [Key]
        public int organization_id { get; set; }
        public string name { get; set; }
        public int admin_id { get; set; }
        public int employee_id { get; set; }
        public Admin admin { get; set; }
        public List<Employee> employee { get; set; }
    }
}
