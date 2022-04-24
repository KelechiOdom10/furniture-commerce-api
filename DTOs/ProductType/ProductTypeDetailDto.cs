using System.ComponentModel.DataAnnotations;
using API.DTOs.Product;

namespace API.DTOs.ProductType;

public class ProductTypeDetailDto : ProductTypeReadDto
{
    [Required]
    public ICollection<ProductReadDto> Products { get; set; } = new List<ProductReadDto>();
}