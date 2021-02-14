using HomeAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeAPI.Controllers {

    [ApiController]
    public class RecipeController : ControllerBase {

        private readonly IRecipeRepository _recipeRepository;

        public RecipeController(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        [HttpGet("api/v1/recipes")]
        public IActionResult GetRecipes() {
            var recipes = _recipeRepository.GetRecipes();
            return new JsonResult(recipes);
        }

    }
}