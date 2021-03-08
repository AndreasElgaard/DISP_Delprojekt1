using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class Vearktoej : Controller
    {
        // GET: Vearktoej
        public ActionResult Index()
        {
            return View();
        }

        // GET: Vearktoej/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vearktoej/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vearktoej/Create
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

        // GET: Vearktoej/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vearktoej/Edit/5
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

        // GET: Vearktoej/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vearktoej/Delete/5
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
