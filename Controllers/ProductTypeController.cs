
using API.DTOs.ProductType;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/productType")]
public class ProductTypeController : ControllerBase
{
    private readonly IProductTypeRepository _productTypeRepository;
    private readonly IMapper _mapper;

    public ProductTypeController(IProductTypeRepository productTypeRepository, IMapper mapper)
    {
        _productTypeRepository = productTypeRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<ProductTypeReadDto>>> GetProductTypes()
    {
        var productTypes = await _productTypeRepository.GetProductTypesAsync();
        return Ok(_mapper.Map<IReadOnlyList<ProductTypeReadDto>>(productTypes));
    }

    [HttpGet("{slug}")]
    public async Task<ActionResult<ProductTypeDetailDto>> GetProductType(string slug)
    {
        var productType = await _productTypeRepository.GetProductTypeBySlugAsync(slug);
        if (productType == null)
            return NotFound();

        return Ok(_mapper.Map<ProductTypeDetailDto>(productType));
    }

    [HttpPost]
    public async Task<ActionResult<ProductTypeReadDto>> AddProductType([FromBody] ProductTypeCreateDto productTypeDto)
    {
        var productTypeExists = await _productTypeRepository.GetProductTypeBySlugAsync(productTypeDto.Slug);
        if (productTypeExists != null)
            return Conflict("Product type already exists");

        var productType = _mapper.Map<ProductType>(productTypeDto);
        var result = await _productTypeRepository.AddProductTypeAsync(productType);
        if (result is null) return BadRequest();

        var productTypeReadDto = _mapper.Map<ProductTypeReadDto>(result);

        return CreatedAtAction(nameof(GetProductTypes), new { id = productTypeReadDto.Id }, productTypeReadDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProductType(int id, [FromBody] ProductTypeUpdateDto productTypeDto)
    {
        if (id != productTypeDto.Id)
            return BadRequest();

        var productTypeFromDb = await _productTypeRepository.GetProductTypeByIdAsync(id);
        if (productTypeFromDb == null)
            return NotFound();

        _mapper.Map(productTypeDto, productTypeFromDb);

        var result = await _productTypeRepository.UpdateProductTypeAsync(productTypeFromDb);
        if (!result) return BadRequest();

        return Ok(productTypeFromDb);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProductType(int id)
    {
        var productType = await _productTypeRepository.GetProductTypeByIdAsync(id);
        if (productType == null)
            return NotFound();

        var result = await _productTypeRepository.DeleteProductTypeByIdAsync(id);
        if (!result) return BadRequest();

        return NoContent();
    }
}
