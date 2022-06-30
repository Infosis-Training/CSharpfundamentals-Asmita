using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Models;

namespace MovieManagement.Data
{
    public class MovieManagementDb : IdentityDbContext
    {
        public MovieManagementDb(DbContextOptions<MovieManagementDb> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieManagement.Models.Crew>? Crew { get; set; }

        public DbSet<Genre>? Genre { get; set; }
    }
}
