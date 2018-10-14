﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebAplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Calculate(int number1, int number2)
        {
            this.ViewBag.number1 = number1;
            this.ViewBag.number2 = number2;
            this.ViewBag.calculate = number2 + number1;
            return View("Index");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}