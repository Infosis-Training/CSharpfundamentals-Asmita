using Microsoft.AspNetCore.Mvc;
using MovieManagement.Models;
using System.Collections.Generic;

namespace MovieManagement.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            //movies.Add(new Movie()
            //{
            //    Name = "3 Idiots",
            //    Code = "A",
            //    Genre = "Comedy",
            //    Description = "Movie Based on Real Story",
            //    LengthInMin = 178,
            //    ReleaseDate = DateTime.Parse("2015-01-01")
            //});
            Movie movie1 = new()
            {
                Name = "3 Idiots",
                Code = "A",
                Genre = "comedy",
                Description = "movie based on real story",
                LengthInMin = 178,
                ReleaseDate = DateTime.Parse("2015-01-01")
            };
            Movie movie2 = new()
            {
                Name = "KGF",
                Code = "B",
                Genre = "Action Drama",
                Description = "movie based on gold smuggling",
                LengthInMin = 188,
                ReleaseDate = DateTime.Parse("2020-01-01")
            };
            Movie movie3 = new()
            {
                Name = "KGF 2",
                Code = "A",
                Genre = "Action Drama",
                Description = "movie based on gold smuggling",
                LengthInMin = 198,
                ReleaseDate = DateTime.Parse("2022-01-01")
            };
            List<Movie> movies = new() { movie1, movie2, movie3 };

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
            return RedirectToAction(nameof(Index));
        }
    }
}

