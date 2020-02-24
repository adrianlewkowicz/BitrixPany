using Microsoft.EntityFrameworkCore;
using Portfolio.API.Models;

namespace Portfolio.API.Data
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options)
        {
            if (options is null)
               {
                throw new System.ArgumentNullException(nameof(options));
               }
        }

        public DbSet<Blog> Blogs{ get; set; }
    }
}