
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace commerceAPI.Controllers;

[ApiController]
[Route("api/productType")]
public class ProductTypeController : ControllerBase
{
    private readonly IProductTypeRepository _productTypeRepository;

    public ProductTypeController(IProductTypeRepository productTypeRepository)
    {
        _productTypeRepository = productTypeRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
    {
        return Ok(await _productTypeRepository.GetProductTypesAsync());
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<ProductType>> GetProductType(string name)
    {
        var productType = await _productTypeRepository.GetProductTypeByNameAsync(name);
        if (productType == null)
            return NotFound();

        return Ok(productType);
    }

    [HttpPost]
    public async Task<ActionResult<ProductType>> AddProductType([FromBody] ProductType productType)
    {
        var productTypeExists = await _productTypeRepository.GetProductTypeByNameAsync(productType.Name);
        if (productTypeExists != null)
            return Conflict("Product type already exists");

        bool result = await _productTypeRepository.AddProductTypeAsync(productType);
        if (!result) return BadRequest();

        return CreatedAtAction(nameof(GetProductTypes), new { id = productType.Id }, productType);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProductType(Guid id, [FromBody] ProductType productType)
    {
        if (id != productType.Id)
            return BadRequest();

        var productTypeFromDb = await _productTypeRepository.GetProductTypeByIdAsync(id);
        if (productTypeFromDb == null)
            return NotFound();

        productTypeFromDb.Name = productType.Name;

        bool result = await _productTypeRepository.UpdateProductTypeAsync(productTypeFromDb);
        if (!result) return BadRequest();

        return Ok(productTypeFromDb);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProductType(Guid id)
    {
        var productType = await _productTypeRepository.GetProductTypeByIdAsync(id);
        if (productType == null)
            return NotFound();

        bool result = await _productTypeRepository.DeleteProductTypeByIdAsync(id);
        if (!result) return BadRequest();

        return NoContent();
    }
}
