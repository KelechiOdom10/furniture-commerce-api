using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Entities;

[Index(nameof(Name), IsUnique = true)]
public class Category : BaseEntity
{
    [Required]
    [MaxLength(32)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [MaxLength(200)]
    public string Description { get; set; } = string.Empty;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}