using Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectScheduleController(IProjectScheduleService projectScheduleService) : ControllerBase
{
    private readonly IProjectScheduleService _projectScheduleService = projectScheduleService;

    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var projectschedules = await _projectScheduleService.GetProjectSchedulesAsync();
        return Ok(projectschedules);
    }

}
