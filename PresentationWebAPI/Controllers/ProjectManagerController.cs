using Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectManagerController(IProjectManagerService projectManagerService) : ControllerBase
{
    private readonly IProjectManagerService _projectManagerService = projectManagerService;

    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var projectmanagers = await _projectManagerService.GetProjectManagersAsync();
        return Ok(projectmanagers);
    }

}
