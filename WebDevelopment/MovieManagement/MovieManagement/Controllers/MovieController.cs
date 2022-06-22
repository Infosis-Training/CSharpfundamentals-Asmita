using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Data;
using MovieManagement.Mapper;
using MovieManagement.Models;
using MovieManagement.ViewModel;
using System.Collections.Generic;

namespace MovieManagement.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieManagementDb _db;

        //dependency injection
        public MovieController(MovieManagementDb db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var movies = _db.Movies.Include(x=>x.Genre).ToList();

            var movieViewModels = movies.Select(y => y.ToViewModel()).ToList();

            return View(movieViewModels);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {

            MovieViewModel movieViewModel = new()
            {
                Genres = GetGenreSelectListItems()
            };

            return View(movieViewModel);
        }

        [HttpPost]
        public IActionResult Add(MovieViewModel movieViewModel)
        {
            var movie = movieViewModel.ToModel();

            //Do something with movie object
            _db.Movies.Add(movie);



            // Commite to the database 
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var movieToEdit = _db.Movies.Find(id);
            var movieViewModel = movieToEdit.ToViewModel();
            movieViewModel.Genres = GetGenreSelectListItems();

            return View();
        }

        [HttpPost]
        public IActionResult Update(Movie movie1)
        {
            _db.Movies.Update(movie1);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var change = _db.Movies.Find(id);
            return View(change);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie1)
        {
            _db.Movies.Remove(movie1);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        private List<SelectListItem> GetGenreSelectListItems()
        {
            var genres = _db.Genre.ToList();

            var genresItems = genres.Select(x =>
                            new SelectListItem
                            {
                                Text = x.Name,
                                Value = x.Id.ToString()
                            }).ToList();

            genresItems.Add(new SelectListItem { Text = "Choose gender...", Value = "", Selected = true });

            return genresItems;
        }
    }
}
