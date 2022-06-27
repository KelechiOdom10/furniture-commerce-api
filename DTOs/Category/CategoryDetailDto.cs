using API.DTOs.Product;
using API.DTOs.ProductType;

namespace API.DTOs.Category;

public class CategoryDetailDto : CategoryReadDto
{
    public ICollection<ProductReadDto> Products { get; set; } = new List<ProductReadDto>();
    public ICollection<ProductTypeReadDto> ProductTypes { get; set; } = new List<ProductTypeReadDto>();
}

