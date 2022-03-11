using Microsoft.AspNetCore.Mvc;
using API.Interfaces;
using API.Entities;
using AutoMapper;
using API.DTOs.Category;

namespace API.Controllers;

[ApiController]
[Route("api/category")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<CategoryReadDto>>> GetCategories()
    {
        var categories = await _categoryRepository.GetCategoriesAsync();
        return Ok(_mapper.Map<IReadOnlyList<CategoryReadDto>>(categories));
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<CategoryDetailDto>> GetCategory(string name)
    {
        var category = await _categoryRepository.GetCategoryByNameAsync(name);
        if (category == null)
            return NotFound();

        return Ok(_mapper.Map<CategoryDetailDto>(category));
    }

    [HttpPost]
    public async Task<ActionResult<CategoryReadDto>> AddCategory([FromBody] CategoryCreateDto categoryDto)
    {
        var categoryExists = await _categoryRepository.GetCategoryByNameAsync(categoryDto.Name);
        if (categoryExists != null)
            return Conflict("Category already exists");

        var category = _mapper.Map<Category>(categoryDto);

        var result = await _categoryRepository.AddCategoryAsync(category);
        if (result is null) return BadRequest();

        var categoryReadDto = _mapper.Map<CategoryReadDto>(result);

        return CreatedAtAction(nameof(GetCategories), new { id = categoryReadDto.Id }, categoryReadDto);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateCategory(Guid id, [FromBody] CategoryUpdateDto categoryDto)
    {
        if (id != categoryDto.Id)
            return BadRequest();

        var category = await _categoryRepository.GetCategoryByIdAsync(id);
        if (category == null)
            return NotFound();

        _mapper.Map(categoryDto, category);

        var result = await _categoryRepository.UpdateCategoryAsync(category);
        if (!result)
            return BadRequest();

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteCategory(Guid id)
    {
        var category = await _categoryRepository.GetCategoryByIdAsync(id);
        if (category == null)
            return NotFound();

        var result = await _categoryRepository.DeleteCategoryByIdAsync(id);
        if (!result)
            return BadRequest();

        return NoContent();
    }
}

