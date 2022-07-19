using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Api.Models;
using MovieManagementApi.Models;

namespace MovieManagement.Api.Data
{
    public class MovieManagementApiContext : DbContext
    {
        public MovieManagementApiContext (DbContextOptions<MovieManagementApiContext> options)
            : base(options)
        {
        }

        //public DbSet<MovieManagement.Api.Models.Movie>? Movie { get; set; }
        public DbSet<Movie>? Movie { get; set; }
        public DbSet<Genre>? Genre { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Movie>().HasOne(x => x.Genre);
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
