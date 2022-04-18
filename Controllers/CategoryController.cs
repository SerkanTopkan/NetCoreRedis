using Microsoft.AspNetCore.Mvc;
using NetCoreRedis.Services;
namespace NetCoreRedis.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    [HttpGet("category/getall")]
    public IActionResult GetAll()
    {
        return Ok(_categoryService.GetAllCategory());
    }
}

