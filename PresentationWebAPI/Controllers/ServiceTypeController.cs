using Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceTypeController(IServiceTypeService serviceTypeService) : ControllerBase
{
    private readonly IServiceTypeService _serviceTypeService = serviceTypeService;

    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var servicetypes = await _serviceTypeService.GetServiceTypesAsync();
        return Ok(servicetypes);
    }

}
