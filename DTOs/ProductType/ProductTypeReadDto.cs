using System.ComponentModel.DataAnnotations;

namespace API.DTOs.ProductType;

public class ProductTypeReadDto : BaseDto
{
    [Required]
    public string Name { get; set; } = String.Empty;
    [Required]
    public string CategoryName { get; set; } = String.Empty;
    [Required]
    public string Slug { get; set; } = String.Empty;
    [Required]
    public string ImageUrl { get; set; } = String.Empty;
    [Required]
    public string CategorySlug { get; set; } = String.Empty;

}