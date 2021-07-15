using System.Collections.Generic;
using SpiceGirl.Data;
using SpiceGirl.Models;

namespace SpiceGirl.Services
{
  public class RecipesService
  {
    private readonly RecipesRepository _recipeRepo;

    public RecipesService(RecipesRepository recipeRepo)
    {
      _recipeRepo = recipeRepo;
    }
    public List<Recipe> GetRecipes()
    {
      return _recipeRepo.GetRecipes();
    }

    public Recipe CreateRecipe(Recipe recipe)
    {
      int id = _recipeRepo.CreateRecipe(recipe);
      recipe.Id = id;
      return recipe;
    }
  }
}