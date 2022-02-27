using Microsoft.AspNetCore.Mvc;
using API.Interfaces;
using API.Entities;


namespace API.Controllers;

[ApiController]
[Route("api/categories")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<Category>>> GetCategories()
    {
        return Ok(await _categoryRepository.GetCategoriesAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Category>> GetCategory(Guid id)
    {
        var category = await _categoryRepository.GetCategoryByIdAsync(id);
        if (category == null)
            return NotFound();

        return Ok(category);
    }

    [HttpPost]
    public async Task<ActionResult<Category>> AddCategory([FromBody] Category category)
    {
        var categoryExists = await _categoryRepository.GetCategoryByNameAsync(category.Name);
        if (categoryExists != null)
            return Conflict("Category already exists");

        await _categoryRepository.AddCategoryAsync(category);
        return CreatedAtAction(nameof(GetCategories), new { id = category.Id }, category);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCategory(Guid id, [FromBody] Category category)
    {
        if (id != category.Id)
            return BadRequest();

        var categoryFromDb = await _categoryRepository.GetCategoryByIdAsync(id);
        if (categoryFromDb == null)
            return NotFound();

        categoryFromDb.Name = category.Name;
        categoryFromDb.Description = category.Description;

        bool result = await _categoryRepository.UpdateCategoryAsync(categoryFromDb);
        if (!result)
            return BadRequest();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategory(Guid id)
    {
        var category = await _categoryRepository.GetCategoryByIdAsync(id);
        if (category == null)
            return NotFound();

        bool result = await _categoryRepository.DeleteCategoryByIdAsync(id);
        if (!result)
            return BadRequest();

        return NoContent();
    }
}

