using Business.Interfaces;
using Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TypeOfIndustryController(ITypeOfIndustryService typeOfIndustryService) : ControllerBase
{
    private readonly ITypeOfIndustryService _typeOfIndustryService = typeOfIndustryService;

    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var typeofindustries = await _typeOfIndustryService.GetTypeOfIndustriesAsync();
        return Ok(typeofindustries);
    }

}