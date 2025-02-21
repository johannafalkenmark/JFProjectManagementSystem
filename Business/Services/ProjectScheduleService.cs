using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class ProjectScheduleService(IProjectScheduleRepository projectScheduleRepository) : IProjectScheduleService
{
    private readonly IProjectScheduleRepository _projectScheduleRepository = projectScheduleRepository;

    public async Task<IEnumerable<ProjectSchedule>> GetProjectSchedulesAsync()
    {
        var entities = await _projectScheduleRepository.GetAllAsync();

        var projectschedules = entities.Select(ProjectScheduleFactory.Create);
        return projectschedules;
    }
}
