using System.Collections.Generic;
using HomeAPI.Entites;

namespace HomeAPI.Services
{
    public interface IRecipeRepository
    {
        List<Recipe> GetRecipes();
        List<Ingredient> GetIngredients();
    }
}