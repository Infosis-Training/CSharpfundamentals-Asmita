using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MovieManagement.Models;

namespace HelloApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public List<Movie> Get()
        {
            //ADO.NET
            List<Movie> movies = new List<Movie>();
            SqlConnection connection = new("Server=(localdb)\\mssqllocaldb;Database=MovieDb")
            return "Hello";
        }
    }
}
