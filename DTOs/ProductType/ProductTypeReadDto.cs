using System.ComponentModel.DataAnnotations;

namespace API.DTOs.ProductType;

public class ProductTypeReadDto : BaseDto
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string CategoryName { get; set; } = string.Empty;
    [Required]
    public string Slug { get; set; } = string.Empty;
    [Required]
    public string ImageUrl { get; set; } = string.Empty;
    [Required]
    public string CategorySlug { get; set; } = string.Empty;

}