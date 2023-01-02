using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDatabaseFirstEF.Models;

namespace MvcDatabaseFirstEF.Controllers
{
    public class Default1Controller : Controller
    {
        // GET: Default1
        public ActionResult Index()

        {

            using (var ctx = new EmployeeDBEntities())

            {

                List<EmployeeDetail> Employeelist = ctx.EmployeeDetails.ToList();

                return View(Employeelist);

            }

        }
    }
}