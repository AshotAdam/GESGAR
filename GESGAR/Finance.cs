﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GESGAR
{
    public class Finance : Controller
    {
        // GET: Finance
        public ActionResult Index()
        {
            return View();
        }

        // GET: Finance/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Finance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Finance/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Finance/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Finance/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Finance/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Finance/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
