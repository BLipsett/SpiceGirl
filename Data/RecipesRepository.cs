using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using SpiceGirl.Models;

namespace SpiceGirl.Data
{
  public class RecipesRepository
  {
    private readonly IDbConnection _db;

    public RecipesRepository(IDbConnection db)
    {
      _db = db;
    }

    public List<Recipe> GetRecipes()
    {
      var sql = @"
      SELECT * FROM recipes
      ";

      return _db.Query<Recipe>(sql).ToList();
    }

    public int CreateRecipe(Recipe recipe)
    {
      string sql = @"
      INSERT INTO recipes 
      (id, title, description, imgUrl, steps, ingredients, creator, creatorId)
      VALUES
      (@id, @title, @description, @imgUrl, @steps, @ingredients, @creator, @creatorId)
      
      ";
      return _db.ExecuteScalar<int>(sql, recipe);
    }
  }
}