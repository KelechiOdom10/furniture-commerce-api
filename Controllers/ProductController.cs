using Microsoft.AspNetCore.Mvc;
using API.DTOs.Product;
using API.Interfaces;
using API.Entities;
using AutoMapper;

namespace API.Controllers;

[ApiController]
[Route("api/product")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductController(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<ProductReadDto>>> GetProducts()
    {
        var products = await _productRepository.GetProductsAsync();
        return Ok(_mapper.Map<IReadOnlyList<ProductReadDto>>(products));
    }

    [HttpGet("{slug}")]
    public async Task<ActionResult<ProductDetailDto>> GetProduct(string slug)
    {
        var product = await _productRepository.GetProductBySlugAsync(slug);
        if (product == null)
            return NotFound();

        return Ok(_mapper.Map<ProductDetailDto>(product));
    }

    [HttpPost]
    public async Task<ActionResult<ProductReadDto>> AddProduct([FromBody] ProductCreateDto productDto)
    {
        var productExists = await _productRepository.ProductExistsAsync(productDto.Name, productDto.Slug);
        if (productExists)
            return Conflict("Product with name or slug already exists");

        var product = _mapper.Map<Product>(productDto);

        var result = await _productRepository.AddProductAsync(product);
        if (result is null) return BadRequest();

        var productReadDto = _mapper.Map<ProductReadDto>(result);

        return CreatedAtAction(nameof(GetProducts), new { id = productReadDto.Id }, productReadDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductUpdateDto productDto)
    {
        if (id != productDto.Id)
            return BadRequest();

        var product = await _productRepository.GetProductByIdAsync(id);
        if (product == null)
            return NotFound();

        _mapper.Map(productDto, product);

        var result = await _productRepository.UpdateProductAsync(product);
        if (!result)
            return BadRequest();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var product = await _productRepository.GetProductByIdAsync(id);
        if (product == null)
            return NotFound();

        var result = await _productRepository.DeleteProductByIdAsync(id);
        if (!result)
            return BadRequest();

        return NoContent();
    }
}
