using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.DTOs.Product;

public class ProductUpdateDto : BaseDto
{
    [MaxLength(40)]
    public string Sku { get; set; } = string.Empty;
    [Required]
    public string Slug { get; set; } = string.Empty;
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    public ICollection<string> Images { get; set; } = new List<string>();
    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public bool IsAvailable { get; set; }
    [Required]
    public int ProductTypeId { get; set; }
    [Required]
    public int CategoryId { get; set; }
}
