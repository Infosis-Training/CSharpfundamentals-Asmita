using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Api.Models;

namespace MovieManagement.Api.Data
{
    public class MovieManagementApiContext : DbContext
    {
        public MovieManagementApiContext (DbContextOptions<MovieManagementApiContext> options)
            : base(options)
        {
        }

        public DbSet<MovieManagement.Api.Models.Movie>? Movie { get; set; }
    }
}
