using DropDown1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace DropDown1.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCourse()
        {
            using (DataDBContext db = new DataDBContext())
            {
                var list = db.Courses.ToList();
                if (list != null)
                {
                    ViewBag.Data = list;
                }
                return View();
            }
               
           
        }
        [HttpPost]
        public ActionResult GetCourse(tbl_Data dt)
        {
            using (GetDataDBContext db = new GetDataDBContext())
            {
                db.datas.Add(dt);
                db.SaveChanges();
               
            }

            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}