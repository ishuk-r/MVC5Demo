using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC5Demo.Models
{
    /// <summary>
    /// Movies class
    /// </summary>
    public class Movies
    {
        public int ID { get; set; }
        public string Title { get; set; }
    }

    public class MovieDbContext : DbContext
    {
        public MovieDbContext() : base("MovieDbContext")
        {

        }
        public DbSet<Movies> Movies { get; set; }
    }
}