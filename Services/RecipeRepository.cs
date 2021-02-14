using System;
using System.Collections.Generic;
using HomeAPI.Entites;
using HomeAPI.DbContexts;
using System.Linq;

namespace HomeAPI.Services 
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly RecipeContext _context;
        public RecipeRepository(RecipeContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddIngredient(Guid recipeId, Ingredient ingredient)
        {
            if (recipeId == Guid.Empty) {
                throw new ArgumentNullException(nameof(recipeId));
            }

            if (ingredient == null) {
                throw new ArgumentNullException(nameof(ingredient));
            }

            ingredient.RecipeId = recipeId;
            _context.Ingredients.Add(ingredient);
        }

        public void AddRecipe(Recipe recipe)
        {
            if (recipe == null) {
                throw new ArgumentNullException(nameof(recipe));
            }

            _context.Recipes.Add(recipe);
            _context.SaveChanges();
        }

        public void DeleteIngredient(Ingredient ingrendient)
        {

            if (ingrendient == null) {
                throw new ArgumentNullException(nameof(ingrendient));
            }

            _context.Ingredients.Remove(ingrendient);            
        }

        public void DeleteRecipe(Recipe recipe)
        {
            if (recipe == null) {
                throw new ArgumentNullException(nameof(recipe));
            }

            _context.Remove(recipe);
        }

        public IQueryable<Ingredient> GetIngredients()
        {
            return _context.Ingredients.AsQueryable();
            throw new System.NotImplementedException();
        }

        public Recipe GetRecipe(Guid Id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Recipe> GetRecipes()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            if (ingredient == null) {
                throw new ArgumentNullException(nameof(ingredient));
            }

            _context.Ingredients.Update(ingredient);
        }

        public void UpdateRecipe(Recipe recipe)
        {

            if (recipe == null) {
                throw new ArgumentNullException(nameof(recipe));
            }

            _context.Recipes.Update(recipe);
        }
    }
}