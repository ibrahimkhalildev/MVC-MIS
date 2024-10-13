using MVC_MIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_MIS.Controllers
{
    public class FindController : Controller
    {
        // GET: Find
        public ActionResult Branch()
        {
            return View();
        }
        public ActionResult Employee()
        {
            BaseEmployee obj = new BaseEmployee();
            obj.EmployeeName = "Ibrahim khalil";
            obj.EmployeeCode = "EMP 001";
            return View(obj);
        }
        [HttpPost]
        public ActionResult Employee(BaseEmployee model)
        {
            ModelState.Clear();
            model.EmployeeName = "Ibrahim Khalil65";
            model.EmployeeCode = "EMP 003";
            return View(model);

            //ModelState.Clear();
            //BaseEmployee obj = new BaseEmployee();
            //model.EmployeeName = "Rahat Ali";
            //model.EmployeeCode = "EMP 003";
            //return View(model);

        }
        public ActionResult Customer()
        {
            BaseEmployee obj = new BaseEmployee();
            obj.EmployeeName = "Abdul Jalil";
            obj.EmployeeCode = "EMP 002";
            return View(obj);
        }
    }
}