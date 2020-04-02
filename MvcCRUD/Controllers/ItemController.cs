using MvcCRUD.Models;
using MvcCRUD.MyContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCRUD.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        myContext connection = new myContext();
        public ActionResult Index()
        {
            return View(connection.Items.ToList());
        }

        // GET: Item/Details/5
        public ActionResult Details(int id)
        {
            return View(connection.Items.Where(S => S.Id == id).FirstOrDefault());
        }

        // GET: Item/Create
        public ActionResult Create(int id = 0)
        {
            ViewBag.Id = new SelectList(connection.Suppliers, "Id", "Name");//the soure of dropdownlist
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        public ActionResult Create(Item item)
        {
            try
            {
                connection.Items.Add(item);
                connection.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Id = new SelectList(connection.Suppliers, "Id", "Name", item.SupplierId);//the soure of dropdownlist
                return View();
            }
        }

        // GET: Item/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Id = new SelectList(connection.Suppliers, "Id", "Name");//the soure of dropdownlist
            return View(connection.Items.Where(S => S.Id == id).FirstOrDefault());
        }

        // POST: Item/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Item item)
        {
            try
            {
                connection.Entry(item).State = EntityState.Modified; //Code edit data in database
                connection.SaveChanges();
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Id = new SelectList(connection.Suppliers, "Id", "Name", item.SupplierId);//the soure of dropdownlist
                return View();
            }
        }

        // GET: Item/Delete/5
        public ActionResult Delete(int id)
        {
            return View(connection.Items.Where(S => S.Id == id).FirstOrDefault());
        }

        // POST: Item/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Item item)
        {
            try
            {
                var check_item = connection.Items.Where(S => S.Id == id).FirstOrDefault();
                connection.Items.Remove(check_item);
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
