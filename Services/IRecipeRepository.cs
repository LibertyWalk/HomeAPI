using System;
using System.Linq;
using System.Collections.Generic;
using HomeAPI.Entites;

namespace HomeAPI.Services
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> GetRecipes();
        Recipe GetRecipe(Guid Id);
        void AddRecipe(Recipe recipe);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(Recipe recipe);

        IQueryable<Ingredient> GetIngredients();
        void AddIngredient(Guid recipeId, Ingredient ingredient);
        void UpdateIngredient(Ingredient ingredient);
        void DeleteIngredient(Ingredient ingrendient);
    }
}