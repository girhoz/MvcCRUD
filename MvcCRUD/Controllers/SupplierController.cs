using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCRUD.MyContext;
using MvcCRUD.Models;
using System.Data.Entity;

namespace MvcCRUD.Controllers
{
    public class SupplierController : Controller
    {
        myContext connection = new myContext();
        // GET: Supplier/Index
        public ActionResult Index()
        {
            return View(connection.Suppliers.ToList());
        }

        [HttpGet]
        public ActionResult Add(int id = 0)
        {
            return View(new Supplier());
        }

        [HttpPost]
        public ActionResult Add(Supplier supp)
        {
            connection.Suppliers.Add(supp);
            connection.SaveChanges();
            // TODO: Add insert logic here
            return RedirectToAction("Index");
        }

        // GET: Supplier/Details/5
        public ActionResult Details(int id)
        {
            return View(connection.Suppliers.Where(S => S.Id == id).FirstOrDefault());
        }

        // GET: Supplier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Supplier/Create
        [HttpPost]
        public ActionResult Create(Supplier supp)
        {
            try
            {
                connection.Suppliers.Add(supp);
                connection.SaveChanges();
                // TODO: Add insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        // GET: Supplier/Edit/5
        public ActionResult Edit(int id)
        {
            return View(connection.Suppliers.Where(S => S.Id == id).FirstOrDefault());
        }

        // POST: Supplier/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Supplier supp)
        {
            try
            {
                connection.Entry(supp).State = EntityState.Modified; //Code edit data in database
                connection.SaveChanges();
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplier/Delete/5
        public ActionResult Delete(int id)
        {
            return View(connection.Suppliers.Where(S => S.Id == id).FirstOrDefault());
        }

        // POST: Supplier/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Supplier supp)
        {
            try
            {
                var check_supp = connection.Suppliers.Where(S => S.Id == id).FirstOrDefault();
                connection.Suppliers.Remove(check_supp);
                connection.SaveChanges();
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
