namespace API.DTOs.Category;

public class CategoryReadDto : BaseDto
{
    public string Name { get; set; }
    public string Slug { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
