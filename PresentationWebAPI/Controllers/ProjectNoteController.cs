using Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectNoteController(IProjectNoteService projectNoteService) : ControllerBase
{
    private readonly IProjectNoteService _projectNoteService = projectNoteService;

    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var projectnotes = await _projectNoteService.GetProjectNotesAsync();
        return Ok(projectnotes);
    }

}