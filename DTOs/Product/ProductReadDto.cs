using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Product;

public class ProductReadDto : BaseDto
{
    [Required]
    public string Name { get; set; } = String.Empty;
    [Required]
    public string Title { get; set; } = String.Empty;
    [Required]
    public string Slug { get; set; } = String.Empty;
    [Required]
    public string DefaultImage { get; set; } = String.Empty;
    [Required]
    public decimal Price { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public bool IsAvailable { get; set; }
    public string ProductType { get; set; } = String.Empty;
    public string CategoryName { get; set; } = String.Empty;
}
