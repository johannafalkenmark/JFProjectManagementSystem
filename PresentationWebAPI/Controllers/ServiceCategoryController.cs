using Business.Interfaces;
using Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceCategoryController(IServiceCategoryService serviceCategoryService) : ControllerBase
{
    private readonly IServiceCategoryService _serviceCategoryService = serviceCategoryService;

    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var servicecategories = await _serviceCategoryService.GetServiceCategoriesAsync();
        return Ok(servicecategories);
    }

}
