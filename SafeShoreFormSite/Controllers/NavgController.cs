﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SafeShoreFormSite.Controllers
{
    public class NavgController : Controller
    {
        // GET: Navg
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }
    }
}