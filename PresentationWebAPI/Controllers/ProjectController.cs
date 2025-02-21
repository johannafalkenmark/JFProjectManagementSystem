using Business.Interfaces;
using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectsController(IProjectService projectService) : ControllerBase
{
    private readonly IProjectService _projectService = projectService;

    [HttpPost]
    public async Task<IActionResult> Create(ProjectRegistrationForm form)
    {
       
        if (!ModelState.IsValid && form.CustomerId < 1)
            return BadRequest();

        //returnerar bool nedan om den lyckas eller inte
        var result = await _projectService.CreateProjectAsync(form);
        return result ? Created("", null) : Problem();

    }


    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var projects = await _projectService.GetProjectsAsync();
        return Ok(projects);
    }

    //Exempel update pch delete från lektion nedan:

    //[HttpPut]
    //public async Task<IActionResult> Update(ProjectRegistrationForm form)
    //{
    //    await _projectService.UpdateAsync(form)
    //return result ? ok(result) : NotFound();
    //        }

    //[HttpDelete]
    //public async Task<IActionResult> Delete(int id)
    //{
    //    await _projectService.DeleteAsync(id);
    //    return result ? ok(result) : NotFound();
    //}


}
