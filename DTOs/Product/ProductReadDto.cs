namespace API.DTOs.Product;

public class ProductReadDto : BaseDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public string[] Images { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public bool IsAvailable { get; set; }
    public string ProductType { get; set; }
    public string CategoryName { get; set; }
}
