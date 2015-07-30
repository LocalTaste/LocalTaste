<<<<<<< Updated upstream
﻿using LocalTaste.Business.Managers.Interfaces;
using LocalTaste.Domain.POCO;
=======
﻿using LocalTaste.Mvc.Models;
>>>>>>> Stashed changes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocalTaste.Mvc.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantManager restaurantManager;

        public RestaurantController(IRestaurantManager restMgr)
        {
            this.restaurantManager = restMgr;
        }

        // GET: Restaurant
        public ActionResult Index()
        {
            return View();
        }

        // GET: Restaurant/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            var rest = new Restaurant();
            return View(rest);
        }

        // POST: Restaurant/Create
        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            try
            {
                restaurantManager.Add(restaurant);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Restaurant/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Restaurant/Edit/5
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

        // GET: Restaurant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Restaurant/Delete/5
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

        //GET
        public ActionResult Search()
        {
            SearchViewModel vm = new SearchViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Search(SearchViewModel input)
        {
            return View(input);

        }
    }
}
