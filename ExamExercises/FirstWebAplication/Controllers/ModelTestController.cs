using FirstWebAplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebAplication.Controllers
{
    public class ModelTestController : Controller
    {
        // GET: ModelTest
        public ActionResult Index()
        {
            List<EmployeeFirstTest> employeeList = new List<EmployeeFirstTest>();
            EmployeeFirstTest employee = new EmployeeFirstTest();


           employeeList.Add(new EmployeeFirstTest { EmployeeID = 1, Name = "Dido", DepartmentID = "Transport" });
           employeeList.Add(new EmployeeFirstTest { EmployeeID = 2, Name = "Marty", DepartmentID = "IT" });
           employeeList.Add(new EmployeeFirstTest { EmployeeID = 3, Name = "John", DepartmentID = "Transport" });
           employeeList.Add(new EmployeeFirstTest { EmployeeID = 4, Name = "Mark", DepartmentID = "IT" });






           return View(employeeList);
           
        }
    }
}