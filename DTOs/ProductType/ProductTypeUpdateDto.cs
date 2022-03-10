using System.ComponentModel.DataAnnotations;

namespace API.DTOs.ProductType;

public class ProductTypeUpdateDto : BaseDto
{
    [Required]
    [MaxLength(40)]
    public string Name { get; set; }
    public Guid CategoryId { get; set; }
}