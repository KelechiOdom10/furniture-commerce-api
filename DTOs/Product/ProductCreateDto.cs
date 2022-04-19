using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.DTOs.Product;

public class ProductCreateDto
{
    [MaxLength(40)]
    public string Sku { get; set; } = String.Empty;
    [Required]
    public string Slug { get; set; } = String.Empty;
    [Required]
    public string Name { get; set; } = String.Empty;
    [Required]
    public string Title { get; set; } = String.Empty;
    [Required]
    public string Description { get; set; } = String.Empty;
    public ICollection<string> Images { get; set; } = new List<string>();
    [Required]
    [DefaultValue(0)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    [Required]
    public int Quantity { get; set; }
    [DefaultValue(true)]
    public bool IsAvailable { get; set; }
    [Required]
    public int ProductTypeId { get; set; }
    [Required]
    public int CategoryId { get; set; }
}
