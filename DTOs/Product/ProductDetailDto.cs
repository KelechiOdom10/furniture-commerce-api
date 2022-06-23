using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Product;

public class ProductDetailDto : ProductReadDto
{
    public string Description { get; set; } = string.Empty;
    [Required]
    public string ProductTypeSlug { get; set; } = String.Empty;
    [Required]
    public string CategorySlug { get; set; } = String.Empty;
    [Required]
    public ICollection<string> Images { get; set; } = new List<string>();
}
