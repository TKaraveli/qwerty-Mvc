﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qwerty.Models;

namespace Qwerty.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Coherence"};

            //return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }
    }
}