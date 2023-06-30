using CloudlyEF.Models;
using CloudlyEF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Linq;

namespace CloudlyEF.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var Movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(Movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        // GET: Movies
        public ActionResult Random()
        {
            var Movies = new Movies() { Name = "Adipurush !" };

            var customers = new List<Customers>
            {  new Customers { Id=1, Name="Customer 1"},
                new Customers { Id=2, Name="Customer 2"}
            };
            
            var viewModel = new RandomMovieViewModel
            {
                Movie = Movies,
                Customer = customers
            };

            return View(viewModel);
        }

        
    }
}