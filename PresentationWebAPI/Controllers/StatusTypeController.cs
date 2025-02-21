using Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StatusTypeController(IStatusTypeService statusTypeService) : ControllerBase
{
    private readonly IStatusTypeService _statusTypeService = statusTypeService;

    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var statustypes = await _statusTypeService.GetStatusTypesAsync();
        return Ok(statustypes);
    }

}

