using API.DTOs.Product;

namespace API.DTOs.ProductType;

public class ProductTypeDetailDto : ProductTypeReadDto
{
    public ICollection<ProductReadDto> Products { get; set; }
}