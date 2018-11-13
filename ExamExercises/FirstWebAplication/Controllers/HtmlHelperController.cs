using FirstWebAplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebAplication.Controllers
{
    public class HtmlHelperController : Controller
    {
     
        public ActionResult Index()
        {

            FirstWebAplicationDatabaseEntities db = new FirstWebAplicationDatabaseEntities();
            List<Employee> employees = db.Employees.ToList();
            ViewBag.NewList = new SelectList(employees,"Id","Department");


            return View("Index");
        }

        public ActionResult SaveRecord(Model.EmployeeViewModel model)
        {
            try
            {
                FirstWebAplicationDatabaseEntities db = new FirstWebAplicationDatabaseEntities();
                Employee employee = new Employee();
                
                



                employee.Name = model.Name;
                employee.Department = model.Department;
                employee.DepartmentId = model.DepartmentId;



                db.Employees.Add(employee);
                db.SaveChanges();

                int id = employee.Id;

                
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return RedirectToAction("Index");
        }
    }
}