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
       
        if (!ModelState.IsValid || form.CustomerId < 1)
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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var project = await _projectService.GetSingleProjectAsync(id);
        return project == null ? NotFound() : Ok(project);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, ProjectRegistrationForm form)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var result = await _projectService.UpdateProjectAsync(id, form);
        return result ? NoContent() : NotFound();
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _projectService.DeleteProjectAsync(id);
        return result ? NoContent() : NotFound();
    }


    //[HttpPut("{id}")]
    //public async Task<IActionResult> Update(ProjectRegistrationForm form)
    //{
    //   var result = await _projectService.UpdateProjectAsync(projectId, form)
    //return result ? ok(result) : NotFound();
    //}

    //[HttpDelete]
    //public async Task<IActionResult> Delete(int id)
    //{
    //    await _projectService.DeleteAsync(id);
    //    return result ? ok(result) : NotFound();
    //}


}
