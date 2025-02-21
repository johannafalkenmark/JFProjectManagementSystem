using Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CostController(ICostService costService) : ControllerBase
{
    private readonly ICostService _costService = costService;

    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var costs = await _costService.GetCostsAsync();
        return Ok(costs);
    }


}
