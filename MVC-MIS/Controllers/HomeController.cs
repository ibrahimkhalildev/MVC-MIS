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
            int hdTotalRow = Convert.ToInt32(formCollection["hdTotalRow"].ToString());
            for (int i = 0; i < hdTotalRow; i++)
            {
                if (formCollection["chk_" + i.ToString()] != null)
                {
                    if (formCollection["chk_" + i.ToString()].ToString().ToLower() == "on")
                    {
                        string txtName = formCollection["txtName_" + i.ToString()].ToString();
                        string txtAge = formCollection["txtAge_" + i.ToString()].ToString();
                        string txtEducation = formCollection["txtEducation_" + i.ToString()].ToString();
                        string txtHobby = formCollection["txtHobby_" + i.ToString()].ToString();
                        string ddlSelect = formCollection["ddlSelect_" + i.ToString()].ToString();
                    }

                }

            }

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