using MVC_MIS.Models;
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
        public JsonResult GetMobileCollection()
        {
            Human human = new Human();
            human.Name = "Ibrahim Khalil";
            human.Age = 31;

            Mobile obj = new Mobile();
            obj.Name = "iPhone";
            human.List_Mobile.Add(obj);

            obj = new Mobile();
            obj.Name = "Samsung";
            human.List_Mobile.Add(obj);

            return Json(human, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetHumanCollection()
        {
            List<Human> lsthuman = new List<Human>();

            Human human = new Human();
            human.Name = "Ibrahim Khalil";
            human.Age = 31;
            lsthuman.Add(human);

            human = new Human();
            human.Name = "Rihan Jamil";
            human.Age = 55;
            lsthuman.Add(human);

            var data = (from p in lsthuman
                        select new
                        {
                            p.Name,
                            p.Age,
                        }).ToList();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "My Fresh Load";
       
            return View();
        }

        [HttpPost]
        public ActionResult About(string btnSubmit, FormCollection formCollection)
        {
            //int hdTotalRow = Convert.ToInt32(formCollection["hdTotalRow"].ToString());
            //for (int i = 0; i < hdTotalRow; i++)
            //{
            //    if (formCollection["chk_" + i.ToString()] != null)
            //    {
            //        if (formCollection["chk_" + i.ToString()].ToString().ToLower() == "on")
            //        {
            //            string txtName = formCollection["txtName_" + i.ToString()].ToString();
            //            string txtAge = formCollection["txtAge_" + i.ToString()].ToString();
            //            string txtEducation = formCollection["txtEducation_" + i.ToString()].ToString();
            //            string txtHobby = formCollection["txtHobby_" + i.ToString()].ToString();
            //            string ddlSelect = formCollection["ddlSelect_" + i.ToString()].ToString();
            //        }

            //    }

            //}
            string name = formCollection["txtName"].ToString();
            if(name == "abc")
            {
               //return RedirectToAction("Contact", "Home");
               return Redirect("google.com");
            }
            //this is fast way
            //ViewBag.formCollection = formCollection;
            //this is another way.
            //return View(formCollection);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Logout()
        {
            //analysis part
            return RedirectToAction("Index");
        }
    }
}