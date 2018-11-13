using FirstWebAplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebAplication.Controllers
{
    public class MultipleTablesController : Controller
    {

        public ActionResult Index()
        {
            FirstWebAplicationDatabaseEntities firstWebAplicationDatabaseEntities = new FirstWebAplicationDatabaseEntities();

            List<Employee> employeeList = firstWebAplicationDatabaseEntities.Employees.ToList();

            Model.EmployeeViewModel employeeViewModel = new Model.EmployeeViewModel();

            List<Model.EmployeeViewModel> employeeViewModelsList = employeeList.Select(x => new Model.EmployeeViewModel {

                Name = x.Name,
                Id = x.Id,
                Department = x.Department

            }).ToList();


            return View(employeeViewModelsList);
        }
    }
}