﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThanhTraNhaTrang.Controllers.System
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //return RedirectToAction("Index","KeHoachThanhTra");
            return View();
        }        
    }
}