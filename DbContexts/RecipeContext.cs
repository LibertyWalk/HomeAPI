using HomeAPI.Entites;
using Microsoft.EntityFrameworkCore;

namespace HomeAPI.DbContexts
{
    public class RecipeContext : DbContext
    {

        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}