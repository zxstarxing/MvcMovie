using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MvcMovie.Models
{

    public class MvcMovieContext : DbContext
    {

        ILogger<MvcMovieContext> _logger;

        public MvcMovieContext(DbContextOptions<MvcMovieContext> options, ILogger<MvcMovieContext> logger)
          : base(options)
        {
            _logger = logger;
        }

        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
          : base(options)
        {
            
        }

        //public DbSet<DbType> CollectionName { get; set; }
        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
       
    }
}