using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Poc_on_Session.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["Message"] = "Welcome to the homepage User!";
            return View();
        }
        /*
        public ActionResult Index()
        {
            if (Session["Message"] == null)
            {
                // Handle session timeout, maybe redirect to a login page or show a timeout message
                return RedirectToAction("SessionExpired");
            }

            return View();
        }*/

        public ActionResult SessionExpired()
        {
            // Return a view indicating the session has expired
            return View();
        }
    }
    }
