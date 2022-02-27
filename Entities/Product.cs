using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

public class Product : BaseEntity
{
    [Required]
    [MaxLength(40)]
    public string Sku { get; set; } = string.Empty;
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [DefaultValue(0)]
    [Column(TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }
    [DefaultValue(true)]
    public bool IsAvailable { get; set; }

    public Guid CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}