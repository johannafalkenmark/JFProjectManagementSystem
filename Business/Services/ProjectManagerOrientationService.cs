using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class ProjectManagerOrientationService(IProjectManagerOrientationRepository projectManagerOrientationRepository) : IProjectManagerOrientationService
{
    private readonly IProjectManagerOrientationRepository _projectManagerOrientationRepository = projectManagerOrientationRepository;

    public async Task<IEnumerable<ProjectManagerOrientation>> GetProjectManagerOrientationsAsync()
    {
        var entities = await _projectManagerOrientationRepository.GetAllAsync();

        var projectmanagerorientations = entities.Select(ProjectManagerOrientationFactory.Create);
        return projectmanagerorientations;
    }
}