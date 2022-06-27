using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Category;

public class CategoryUpdateDto : BaseDto
{
    [Required]
    [MaxLength(32)]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Slug { get; set; } = string.Empty;
    [Required]
    [MaxLength(200)]
    public string Description { get; set; } = string.Empty;
    [Required]
    public string ImageUrl { get; set; } = string.Empty;
}
