namespace SpiceGirl.Models
{
  public class Recipe
  {
    public Recipe(int id, string title, string description, string imgUrl, int steps, int ingredients, string creator, string creatorId)
    {
      Id = id;
      Title = title;
      Description = description;
      ImgUrl = imgUrl;
      Steps = steps;
      Ingredients = ingredients;
      Creator = creator;
      CreatorId = creatorId;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }
    public int Steps { get; set; }
    public int Ingredients { get; set; }
    public string Creator { get; set; }
    public string CreatorId { get; set; }
  }
}