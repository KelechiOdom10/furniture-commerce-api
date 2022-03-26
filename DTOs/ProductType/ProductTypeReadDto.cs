namespace API.DTOs.ProductType;

public class ProductTypeReadDto : BaseDto
{
    public string Name { get; set; }
    public string CategoryName { get; set; }
    public string Slug { get; set; }
    public string ImageUrl { get; set; }
}