using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Entities;

[Index(nameof(Name), IsUnique = true)]
[Index(nameof(Slug), IsUnique = true)]
public class ProductType : BaseEntity
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Slug { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

