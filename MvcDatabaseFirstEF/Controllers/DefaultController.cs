using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDatabaseFirstEF.Models;

namespace MvcDatabaseFirstEF.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()

        {

            using (var ctx = new EmployeeDBEntities1())

            {

                List<EmployeeDetail> Employeelist = ctx.EmployeeDetails.ToList();

                return View(Employeelist);

            }

        }
    }
}