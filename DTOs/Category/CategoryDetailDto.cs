using API.DTOs.Product;
using API.DTOs.ProductType;

namespace API.DTOs.Category;

public class CategoryDetailDto : CategoryReadDto
{
    public virtual ICollection<ProductReadDto> Products { get; set; }
    public virtual ICollection<ProductTypeReadDto> ProductTypes { get; set; }
}
