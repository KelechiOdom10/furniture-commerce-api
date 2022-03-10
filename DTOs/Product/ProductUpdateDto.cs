using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.DTOs.Product;

public class ProductUpdateDto : BaseDto
{
    [Required]
    [MaxLength(40)]
    public string Sku { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public Guid ProductTypeId { get; set; }
    public Guid CategoryId { get; set; }
}
