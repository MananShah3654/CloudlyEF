using CloudlyEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloudlyEF.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new Movies() { Name = "Adipurush !" };

            //* Different types of Action Results

            //return new ViewResult();
            //return Content("Hello Word!");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home");
            return View(movies);
        }

        #region Action Parameters

        public ActionResult edit(int movieId)
        {
            return Content("id = " + movieId);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        #endregion

        #region Conventional & Attribute Routing

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        #endregion
    }
}