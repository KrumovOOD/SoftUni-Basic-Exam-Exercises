
using FirstWebAplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebAplication.Controllers
{
    public class ModelBindingController : Controller
    {
        
        public ActionResult Index()
        {
           
            FirstWebAplicationDatabaseEntities db = new FirstWebAplicationDatabaseEntities();
            Employee employee = db.Employees.SingleOrDefault(x => x.EmployeeID == 2);

            Model.EmployeeViewModel viewModel = new Model.EmployeeViewModel();

            viewModel.EmployeeID = employee.EmployeeID;
            viewModel.Name = employee.Name;
            viewModel.DepartmentID = employee.DepartmentID;



            return View(viewModel);

        }

       
    }
}