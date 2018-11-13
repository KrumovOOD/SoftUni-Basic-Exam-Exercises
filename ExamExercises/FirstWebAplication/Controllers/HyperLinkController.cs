using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWebAplication.Model;
using FirstWebAplication.Models;

namespace FirstWebAplication.Controllers
{
    public class HyperLinkController : Controller
    {
        
        public ActionResult Index()
        {            
            using(var db = new FirstWebAplicationDatabaseEntities())
            {
               var list = db.Employees.Select(x => new EmployeeViewModel
                {
                    Name = x.Name,
                    Id = x.Id,
                    Department = x.Department
                }).ToList();

                //List<Employee> employees = db.Employees.ToList();
                //List<EmployeeViewModel> employeesModel = employees.Select(x => new EmployeeViewModel { Name = x.Name, EmployeeID = x.EmployeeID, DepartmentID = x.DepartmentID }).ToList();
                               
                return View(list);
            }  
        }


        public ActionResult EmployeeDetail (int id)
        {

            using (var db = new FirstWebAplicationDatabaseEntities())
            {

                Employee employee = db.Employees.SingleOrDefault(x => x.Id == id);
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.Name = employee.Name;
                employeeViewModel.Id = employee.Id;
                employeeViewModel.Department = employee.Department;

                return View("EmployeeDetail", employeeViewModel);
            }
            
           

        }
    }
}