using Microsoft.EntityFrameworkCore;
using RecipeBox.Models;

namespace RecipeBox.Models
{
  public class RecipeBoxContext : DbContext
  {
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<RecipeCategory> RecipeCategory { get; set; }

    public RecipeBoxContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}