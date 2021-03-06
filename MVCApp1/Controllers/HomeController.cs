﻿using MVCApp1.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IDemo1 demo1 = new InterfaceTest();
            demo1.GetDetails();

            IDemo2 demo2 = new InterfaceTest();
            demo2.GetDetails();
            CallingMemento cm = new CallingMemento();
            cm.MementoWrapper();
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