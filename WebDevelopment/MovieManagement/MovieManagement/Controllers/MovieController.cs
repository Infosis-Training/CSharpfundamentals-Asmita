using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Data;
using MovieManagement.Mapper;
using MovieManagement.Models;
using MovieManagement.ViewModel;
using MovieManagement.Helpers;
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
        public IActionResult Index(string searchString, string sortOrder, int pageNumber=1, int pageSize=3)
        {
            ViewData["CurrentSearch"] = sortOrder;
            ViewData["PageNumber"] = pageNumber;

            ViewData["MovieNameSortParam"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["ReleaseDateSortParam"] = sortOrder == "release_date_desc" ? "release_date_asc" : "release_date_desc";
            ViewData["CurrentFilter"] = searchString;

            var movies = _db.Movies.Include(x => x.Genre).AsQueryable();
            //var movieViewModels = new List<MovieViewModel>();

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Name.Contains(searchString)
                                       || s.Description.Contains(searchString));
            }

            movies = sortOrder switch
            {
                "name_desc" => movies.OrderByDescending(x => x.Name),
                "release_date_desc" => movies.OrderByDescending(x => x.ReleaseDate),
                "release_date_asc" => movies.OrderBy(x => x.ReleaseDate),
                "genre_desc" => movies.OrderByDescending(x => x.Genre.Name),
                "genre_asc" => movies.OrderBy(x => x.Genre.Name),
                _ => movies.OrderBy(x => x.Name)
            };
            //var moviesFetched = movies.ToList();
            //if (moviesFetched.Any())
            //{
            //    movieViewModels = moviesFetched.Select(x => x.ToViewModel()).ToList();
            //}
            var moviesFetched = new PaginationList<Movie>(movies, pageNumber, pageSize);

            var list = moviesFetched.ToPaginatedViewModels();
            return View(list);
        }

        [HttpGet]
        public IActionResult Add()
        {

            MovieViewModel movieViewModel = new()
            {
                Genres = GetGenreSelectListItems()
            };

            return View(movieViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm]MovieViewModel movieViewModel)
        {


            if (ModelState.IsValid)
            {
                var movie = movieViewModel.ToModel();

                //Do something with movie object
                _db.Movies.Add(movie);

                // Commite to the database 
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(movieViewModel);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {

            var movieToEdit = _db.Movies.Include(x => x.Genre)
                                        .FirstOrDefault(x => x.Id == id);
            var movieViewModel = movieToEdit?.ToViewModel();
            movieViewModel.Genres = GetGenreSelectListItems();

            if (movieViewModel == null)
                return RedirectToAction(nameof(Index));
            return View(movieViewModel);

        }

        [HttpPost]
        public IActionResult Update(MovieViewModel movieViewModel)
        {
            if (movieViewModel != null && ModelState.IsValid)
            {
                var movieToUpdate = movieViewModel.ToModel();
                _db.Movies.Update(movieToUpdate);
                _db.SaveChanges();
                //return RedirectToAction(nameof(Index));
            }
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

            genresItems.Add(new SelectListItem { Text = "Choose gener...", Value = "", Selected = true });

            return genresItems;
        }
    }
}
