using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Category;

public class CategoryUpdateDto : BaseDto
{
    [Required]
    [MaxLength(32)]
    public string Name { get; set; }
    [Required]
    public string Slug { get; set; }
    [Required]
    [MaxLength(200)]
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
