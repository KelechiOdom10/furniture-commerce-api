using System.ComponentModel.DataAnnotations;
using API.DTOs.Product;

namespace API.DTOs.ProductType;

public class ProductTypeDetailDto : ProductTypeReadDto
{
    [Required]
    public string CategorySlug { get; set; } = String.Empty;
    public ICollection<ProductReadDto> Products { get; set; } = new List<ProductReadDto>();
}