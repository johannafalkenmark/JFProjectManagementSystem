using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class ProjectManagerService(IProjectManagerRepository projectManagerRepository, IProjectManagerOrientationRepository projectManagerOrientationRepository ) : IProjectManagerService
{
    private readonly IProjectManagerRepository _projectManagerRepository = projectManagerRepository;
    private readonly IProjectManagerOrientationRepository _projectManagerOrientationRepository = projectManagerOrientationRepository;

    public async Task<IEnumerable<ProjectManager>> GetProjectManagersAsync()
    {
        var entities = await _projectManagerRepository.GetAllAsync();

        var projectmanagers = entities.Select(ProjectManagerFactory.Create);
        return projectmanagers;
    }
}
