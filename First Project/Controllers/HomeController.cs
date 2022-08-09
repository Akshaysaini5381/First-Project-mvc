using First_Project.db;
using First_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            mvcEntities obj = new mvcEntities();
            var res = obj.firstTables.ToList();
            return View(res);
        }

        public ActionResult About()
        {
            mvcEntities o = new mvcEntities();
            var r = o.firstTables.ToList();

            List<Class1> obj1 = new List<Class1>();
            foreach (var item in r)
            {
                obj1.Add(new Class1
                {
                    Id = item.Id,
                    Name = item.Name,
                    Email = item.Email,
                    City = item.City,
                    Phone = (int)item.Phone
                }) ;
            }
            return View(obj1);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
    }
}