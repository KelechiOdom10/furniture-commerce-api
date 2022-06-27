using System.ComponentModel.DataAnnotations;


namespace API.DTOs.ProductType;

public class ProductTypeCreateDto
{
    [Required]
    [MaxLength(40)]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Slug { get; set; } = string.Empty;
    [Required]
    public string ImageUrl { get; set; } = string.Empty;
    [Required]
    public int CategoryId { get; set; }
}