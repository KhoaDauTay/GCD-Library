using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models;

public class MovieDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite(@"DataSource=movie.db");
        }
    }
    public virtual DbSet<Student> Students { get; set; }
}