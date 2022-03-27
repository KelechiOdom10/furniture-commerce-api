using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.DTOs.Product;

public class ProductCreateDto
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
    public ICollection<string> Images { get; set; }
    [Required]
    [DefaultValue(0)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    [DefaultValue(true)]
    public bool IsAvailable { get; set; }
    public int ProductTypeId { get; set; }
    public int CategoryId { get; set; }
}
