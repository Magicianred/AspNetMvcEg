using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcEg.Models
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }
}