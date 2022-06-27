using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Product;

public class ProductReadDto : BaseDto
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Slug { get; set; } = string.Empty;
    [Required]
    public string DefaultImage { get; set; } = string.Empty;
    [Required]
    public decimal Price { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public bool IsAvailable { get; set; }
    public string ProductTypeName { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
}
