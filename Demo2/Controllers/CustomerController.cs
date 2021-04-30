using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo2.Models;
using System.Data.Entity;

namespace Demo2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            using (dbModels obj = new dbModels())
            {
                return View(obj.Customers.ToList());
            }
                
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using (dbModels obj = new dbModels())
            {
                return View(obj.Customers.Where(x=>x.ID == id).FirstOrDefault());
            }
                
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer custobj)
        {
            try
            {
                // TODO: Add insert logic here
                using (dbModels obj = new dbModels())
                {
                    obj.Customers.Add(custobj);
                    obj.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (dbModels obj = new dbModels())
            {
                return View(obj.Customers.Where(x => x.ID == id).FirstOrDefault());
            }
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer Cust)
        {
            try
            {
                // TODO: Add update logic here
                using (dbModels dbobj = new dbModels())
                {
                    dbobj.Entry(Cust).State = EntityState.Modified;
                    dbobj.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (dbModels obj = new dbModels())
            {
                return View(obj.Customers.Where(x => x.ID == id).FirstOrDefault());
            }
            
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (dbModels dbobj = new dbModels())
                {
                    Customer Cust = dbobj.Customers.Where(x=>x.ID == id).FirstOrDefault();
                    dbobj.Customers.Remove(Cust);
                    dbobj.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
