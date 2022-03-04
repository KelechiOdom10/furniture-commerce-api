using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Entities;

[Index(nameof(Name), IsUnique = true)]
public class ProductType : BaseEntity
{
    [Required]
    [MaxLength(40)]
    public string Name { get; set; } = string.Empty;
    public Guid CategoryId { get; set; }
    public virtual Category? Category { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

