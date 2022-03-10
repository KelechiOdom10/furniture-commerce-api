using System.ComponentModel.DataAnnotations;


namespace API.DTOs.ProductType;

public class ProductTypeCreateDto
{
    [Required]
    [MaxLength(40)]
    public string Name { get; set; }
    public Guid CategoryId { get; set; }
}