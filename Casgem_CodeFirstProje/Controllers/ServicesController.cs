﻿using Casgem_CodeFirstProje.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProje.Controllers
{
    public class ServicesController : Controller
    {
        TravelContext travelContext = new TravelContext();
        // GET: Services
        public ActionResult Index()
        {
            var values = travelContext.Cities.ToList();
            return View(values);
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialServices()
        {           
            return PartialView();
        }

        public PartialViewResult PartialCities()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript2()
        {
            return PartialView();
        }
    }
}