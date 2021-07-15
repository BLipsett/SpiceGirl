using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SpiceGirl.Models;
using SpiceGirl.Services;

namespace SpiceGirl.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class RecipesController : ControllerBase
  {
    private readonly RecipesService _rs;

    public RecipesController(RecipesService rs)
    {
      _rs = rs;
    }
    [HttpGet]
    public ActionResult<List<Recipe>> GetRecipes()
    {
      try
      {
        var recipes = _rs.GetRecipes();
        return Ok(recipes);
      }
      catch (System.Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Recipe> CreateRecipe([FromBody] Recipe recipeData)
    {
      try
      {
        return Ok(_rs.CreateRecipe(recipeData));
      }
      catch (System.Exception e)
      {

        return BadRequest(e.Message);
      }
    }
  }

}