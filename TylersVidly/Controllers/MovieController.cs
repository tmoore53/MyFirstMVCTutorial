using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TylersVidly.Models;

namespace TylersVidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            //var movie = new Movie() { Name = "Peter Pan!" };
            var movie2 = new Movie() { Name = "Saving Private Ryan" };

            return View(movie2);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

        }

        //Custom Route the easier solution.
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }




        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // ? allows you to pass a nullible value through the parameter
        // GET: Movie/
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }

            return Content(string.Format("pageIndex{0}&sortBy={1}", pageIndex, sortBy));
        }

    }
}