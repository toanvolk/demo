using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThanhTraNhaTrang.Controllers.System
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string userid, string password)
        {
            Session["userid"] = userid;
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Profiles()
        {
            return View();
        }
    }
}