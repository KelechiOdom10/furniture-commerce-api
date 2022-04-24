using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

public class Product : BaseEntity
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
    [DefaultValue(0)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    [DefaultValue(5)]
    public int Quantity { get; set; }
    [DefaultValue(true)]
    public bool IsAvailable { get; set; }

    public int ProductTypeId { get; set; }
    public virtual ProductType? ProductType { get; set; }
    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}