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


           employeeList.Add(new EmployeeFirstTest { Id = 1, Name = "Dido", Department = "Transport" });
           employeeList.Add(new EmployeeFirstTest { Id = 2, Name = "Marty", Department = "IT" });
           employeeList.Add(new EmployeeFirstTest { Id = 3, Name = "John", Department = "Transport" });
           employeeList.Add(new EmployeeFirstTest { Id = 4, Name = "Mark", Department = "IT" });






           return View(employeeList);
           
        }
    }
}