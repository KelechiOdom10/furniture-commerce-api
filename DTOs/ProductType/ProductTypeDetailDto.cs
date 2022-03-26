using API.DTOs.Product;

namespace API.DTOs.ProductType;

public class ProductTypeDetailDto : ProductTypeReadDto
{
    public string CategorySlug { get; set; }
    public ICollection<ProductReadDto> Products { get; set; }
}