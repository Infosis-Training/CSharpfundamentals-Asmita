using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Api.Data;

namespace MovieManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly MovieManagementApiContext _context;

        public ReportController(MovieManagementApiContext context)
        {
            _context = context;
        }

        public IActionResult GetMovieWithGenres()
        {
            var query = from movie in _context.Movie
                        join genre in _context.Genre on movie.GenreId equals genre.Id
                        orderby genre.Name ascending
                        select new { Name = movie.Name, GenreName = genre.Name };

            var results = query.ToList();

            return Ok(results);
        }
    }
}
