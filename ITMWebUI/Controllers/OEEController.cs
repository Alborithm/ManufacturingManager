using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMWebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITMWebUI.Controllers
{
    public class OEEController : Controller
    {
        // GET: OEE
        public ActionResult Index()
        {
            // Temporal data to test the view
            List<Operation> output = new List<Operation>();
            output.Add(new Operation()
            {
                Id = 1,
                Name = "Prensa op.10 A",
                Number = 10,
                Line = "Prensado A",
                Disponibility = new Models.OEE.Disnponibility()
                {
                    Id = 1,
                    Disponible = true,
                    OperationId = 1,
                    TimeUpdated = DateTime.Now
                }
            });
            output.Add(new Operation()
            {
                Id = 2,
                Name = "Prensa op.20 A",
                Number = 20,
                Line = "Prensado A",
                Disponibility = new Models.OEE.Disnponibility()
                {
                    Id = 1,
                    Disponible = false,
                    OperationId = 2,
                    TimeUpdated = DateTime.Now
                }
            });
            output.Add(new Operation()
            {
                Id = 3,
                Name = "Prensa op.30 A",
                Number = 30,
                Line = "Prensado A",
                Disponibility = new Models.OEE.Disnponibility()
                {
                    Id = 1,
                    Disponible = true,
                    OperationId = 3,
                    TimeUpdated = DateTime.Now
                }
            });

            return View(output);
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