using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace WebApplication3.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication3.Models.Movie> Movie { get; set; }
    }
}
