using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_MIS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My Fresh Load";

            return View();
        }

        [HttpPost]
        public ActionResult About(string btnSubmit, FormCollection formCollection)
        {
            string txtName = formCollection["txtName"].ToString();
            string txtAge = formCollection["txtAge"].ToString();
            string txtEducation = formCollection["txtEducation"].ToString();
            string txtHobby = formCollection["txtHobby"].ToString();
            string ddlSelect = formCollection["ddlSelect"].ToString();

            ViewBag.Message = "This is Postback Load.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}