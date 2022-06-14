using Microsoft.AspNetCore.Mvc;
using MovieManagement.Data;
using MovieManagement.Models;
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
            var movies = _db.Movies.ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            //randomly generate code
            movie.Code = Guid.NewGuid().ToString();
            _db.Movies.Add(movie);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var change = _db.Movies.Find(id);
            return View(change);
        }

        [HttpPost]
        public IActionResult Update(Movie movie1)
        {
            //var changeData = _db.Movies.Find(movie1.Id);
            //if (changeData != null)
            //{
            //    changeData.Name = movie1.Name;
            //    changeData.Description = movie1.Description;
            //    changeData.Code = movie1.Code;
            //    changeData.Genre = movie1.Genre;
            //    changeData.ReleaseDate = movie1.ReleaseDate;
            //    changeData.LengthInMin = movie1.LengthInMin;
            //    _db.SaveChanges();
            //}
            _db.Movies.Update(movie1);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
