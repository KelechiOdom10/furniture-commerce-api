using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.DTOs.Product;

public class ProductUpdateDto : BaseDto
{
    [MaxLength(40)]
    public string Sku { get; set; }
    [Required]
    public string Slug { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    public string[] Images { get; set; }
    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public bool IsAvailable { get; set; }
    public int ProductTypeId { get; set; }
    public int CategoryId { get; set; }
}
