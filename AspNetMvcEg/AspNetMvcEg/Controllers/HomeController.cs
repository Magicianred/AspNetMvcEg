using AspNetMvcEg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcEg.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult DataTable()
        {
            ViewBag.Message = "Your data tables page.";

            return View();
        }

        public ActionResult LoadTableData()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee {
                    EmployeeName = "Jane Doe",
                    Company = "Alphabet Charley's",
                    Phone = "+1 (777) 777-7777",
                    Country = "USA",
                    City = "New York City",
                    PostalCode = "09876-5432"
                },
                new Employee {
                    EmployeeName = "John Dow",
                    Company = "Gammmify",
                    Phone = "+1 (777) 333-7777",
                    Country = "Canada",
                    City = "Vancouver",
                    PostalCode = "A1A 1A1"
                },
                new Employee {
                    EmployeeName = "Joe",
                    Company = "Omegamedicalls",
                    Phone = "+1 (333) 777-7777",
                    Country = "USA",
                    City = "Johnson City",
                    PostalCode = "23456-7890"
                },
                new Employee {
                    EmployeeName = "Jennie Doe",
                    Company = "Alphabet Charley's",
                    Phone = "+1 (333) 777-7777",
                    Country = "USA",
                    City = "Los Angeles",
                    PostalCode = "09876-5432"
                },
                new Employee {
                    EmployeeName = "Jack \"Zones\" Jacobsons",
                    Company = "Gammmify",
                    Phone = "+81 99-9999-9999",
                    Country = "Japan",
                    City = "Tokyo",
                    PostalCode = "999-9999"
                }
            };

            return Json(new { data = employees }, JsonRequestBehavior.AllowGet);
        }
    }
}