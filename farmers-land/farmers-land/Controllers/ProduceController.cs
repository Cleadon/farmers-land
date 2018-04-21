﻿using farmers_land.Models;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace farmers_land.Controllers
{
    public class ProduceController : Controller
    {
        // GET: Produce
        public ActionResult Index()
        {
            return View();
        }

        // GET: Produce/Details
        public ActionResult Details()
        {
            var produce = new Produce{Id = 1, Name = "carrot", Category = "vegtable", Quantity = 100, Price = 250 };
            return View(produce);
        }

        // GET: Produce/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produce/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produce/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produce/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produce/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produce/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
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