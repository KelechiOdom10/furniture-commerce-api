using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Category;

public class CategoryUpdateDto : BaseDto
{
    [Required]
    [MaxLength(32)]
    public string Name { get; set; } = String.Empty;
    [Required]
    public string Slug { get; set; } = String.Empty;
    [Required]
    [MaxLength(200)]
    public string Description { get; set; } = String.Empty;
    [Required]
    public string ImageUrl { get; set; } = String.Empty;
}
