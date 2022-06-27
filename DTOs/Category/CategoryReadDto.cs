using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Category;

public class CategoryReadDto : BaseDto
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Slug { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [Required]
    public string ImageUrl { get; set; } = string.Empty;
}
