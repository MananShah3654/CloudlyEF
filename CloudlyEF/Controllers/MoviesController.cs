using CloudlyEF.Models;
using CloudlyEF.ViewModel;
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
        public ActionResult Random()
        {
            var movies = new Movies() { Name = "Adipurush !" };

            var customers = new List<Customers>
            {  new Customers { Id=1, Name="Customer 1"},
                new Customers { Id=2, Name="Customer 2"}
            };
            
            var viewModel = new RandomMovieViewModel
            {
                Movie = movies,
                Customer = customers
            };

            return View(viewModel);
        }

        
    }
}