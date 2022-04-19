using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Product;

public class ProductDetailDto : ProductReadDto
{
    [Required]
    public ICollection<string> Images { get; set; } = new List<string>();
}
