﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Con.Model
{
    public class Employee
    {
        [Key]
        public int employee_id { get; set; }
        public string name { get; set; }
    }
}
