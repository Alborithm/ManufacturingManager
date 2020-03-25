﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMWebUI.Library.DataAccess;
using ITMWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITMWebUI.Controllers
{
    public class OEEController : Controller
    {
        [Authorize]
        // GET: OEE
        public ActionResult Index()
        {
            OperationData operations = new OperationData();

            return View(operations.GetOperations());
        }

        // GET: OEE/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OEE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OEE/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OEE/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OEE/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OEE/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OEE/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}