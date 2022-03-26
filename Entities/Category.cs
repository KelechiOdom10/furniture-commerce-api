using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Entities;

[Index(nameof(Name), IsUnique = true)]
[Index(nameof(Slug), IsUnique = true)]
public class Category : BaseEntity
{
    [Required]
    [MaxLength(32)]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [Required]
    public string Slug { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    public virtual ICollection<ProductType> ProductTypes { get; set; } = new List<ProductType>();
}