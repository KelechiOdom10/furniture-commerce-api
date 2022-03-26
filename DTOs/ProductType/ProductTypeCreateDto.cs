using System.ComponentModel.DataAnnotations;


namespace API.DTOs.ProductType;

public class ProductTypeCreateDto
{
    [Required]
    [MaxLength(40)]
    public string Name { get; set; }
    [Required]
    public string Slug { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
}