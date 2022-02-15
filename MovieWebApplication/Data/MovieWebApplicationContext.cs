#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieWebApplication.Models;

namespace MovieWebApplication.Data
{
    public class MovieWebApplicationContext : DbContext
    {
        public MovieWebApplicationContext (DbContextOptions<MovieWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MovieWebApplication.Models.Movie> Movie { get; set; }
    }
}
