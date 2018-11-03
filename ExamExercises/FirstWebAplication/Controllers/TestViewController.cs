using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebAplication.Controllers
{
    public class TestViewController : Controller
    {
        // GET: TestView
        public ActionResult Index()
        {

           
            List<string> list = new List<string>();
            list.Add("Dido");
            list.Add("Marty");
            list.Add("Hello");
            ViewBag.name = list;
            return View();
        }

    }
}