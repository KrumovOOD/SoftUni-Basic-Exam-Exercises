
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
            Employee employee = db.Employees.SingleOrDefault(x => x.Id == 1);

            Model.EmployeeViewModel viewModel = new Model.EmployeeViewModel();

            viewModel.Id = employee.Id;
            viewModel.Name = employee.Name;
            viewModel.Department = employee.Department;



            return View(viewModel);

        }

       
    }
}