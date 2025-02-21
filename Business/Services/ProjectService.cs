
using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;
using Data.Repositories;
using System.Diagnostics;

namespace Business.Services;

public class ProjectService(IProjectRepository projectRepository, ICustomerRepository customerRepository, IProjectManagerRepository projectManagerRepository, IServiceTypeRepository serviceTypeRepository, IStatusTypeRepository statusTypeRepository, IUserRepository userRepository, IProjectNoteRepository projectNoteRepository, IProjectScheduleRepository projectScheduleRepository) : IProjectService
{
    private readonly IProjectRepository _projectRepository = projectRepository;
    private readonly ICustomerRepository _customerRepository = customerRepository;
    private readonly IProjectManagerRepository _projectManagerRepository = projectManagerRepository;
    private readonly IServiceTypeRepository _serviceTypeReposiory = serviceTypeRepository;    
    private readonly IStatusTypeRepository _statusTypeReposiory = statusTypeRepository;    
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IProjectNoteRepository _projectNoteRepository = projectNoteRepository;
    private readonly IProjectScheduleRepository _projectScheduleRepository = projectScheduleRepository;


  
        
        
        
        //CREATE
     async Task<bool> IProjectService.CreateProjectAsync(ProjectRegistrationForm form)

    //nedan kikar om den redan finns
    {
        if (!await _customerRepository.AlreadyExistsAsync(customer => customer.Id == form.CustomerId))
            return false;

      
        var projectEntity = ProjectFactory.Create(form);
        if (projectEntity == null)
            return false;

        //Sätter bool så det blir mer lättläst att det är en bool vi får ut
        bool result = await _projectRepository.CreateAsync(projectEntity);
        return result;

    }

    //READ

    async Task<IEnumerable<Project>> IProjectService.GetProjectsAsync()
    {


        var entities = await _projectRepository.GetAllAsync();
        var projects = entities.Select(ProjectFactory.Create);
        return projects;
    }

    async Task<Project?> IProjectService.GetSingleProjectAsync(int projectId)
    {
        var entity = await _projectRepository.GetAsync(p => p.Id == projectId);
        if (entity == null)
            return null;

        var project = ProjectFactory.Create(entity);
        return project;
    }

    //UPDATE


    async Task<bool> IProjectService.UpdateProjectAsync(int projectId, ProjectRegistrationForm form)
    {
        var existingProject = await _projectRepository.GetAsync(p => p.Id == projectId);
        if (existingProject == null)
            return false;

        try
        {
            var updatedProject = ProjectFactory.Update(existingProject, form);
            if (updatedProject == null)
                return false;

            bool result = await _projectRepository.UpdateAsync(updatedProject);
            return result;
        }
        catch (Exception ex) 
        {
            Debug.WriteLine($"Error updating {nameof(existingProject)} :: {ex.Message}");
            return false;
        }

    }


    //DELETE

    async Task<bool> IProjectService.DeleteProjectAsync(int projectId)

    {
        var existingProject = await _projectRepository.GetAsync(p => p.Id == projectId);
        if (existingProject == null)
            return false;

        try
        {
            bool result = await _projectRepository.DeleteAsync(existingProject);
            return result;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error deleting {nameof(existingProject)} :: {ex.Message}");
            return false;
        }
    }

}




