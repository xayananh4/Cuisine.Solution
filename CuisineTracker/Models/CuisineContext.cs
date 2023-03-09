using Microsoft.EntityFrameworkCore;

namespace CuisineTracker.Models
{
  public class CuisineContext : DbContext
  {
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Review> Reviews { get; set; }

    public CuisineContext(DbContextOptions options) : base(options) { }
  }
}