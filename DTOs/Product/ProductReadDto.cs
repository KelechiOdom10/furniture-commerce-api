namespace API.DTOs.Product;

public class ProductReadDto : BaseDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public Guid ProductTypeId { get; set; }
    public string ProductType { get; set; }
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; }
}
