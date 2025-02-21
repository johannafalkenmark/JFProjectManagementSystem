using Business.Interfaces;
using Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectManagerOrientationController(IProjectManagerOrientationService projectManagerOrientationService) : ControllerBase
{
    private readonly IProjectManagerOrientationService _projectManagerOrientationService = projectManagerOrientationService;

    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var projectmanagerorientations = await _projectManagerOrientationService.GetProjectManagerOrientationsAsync();
        return Ok(projectmanagerorientations);
    }

}
