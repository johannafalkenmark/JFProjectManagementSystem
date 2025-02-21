using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class ProjectNoteService(IProjectNoteRepository projectNoteRepository) : IProjectNoteService
{
    private readonly IProjectNoteRepository _projectNoteRepository = projectNoteRepository;

    public async Task<IEnumerable<ProjectNote>> GetProjectNotesAsync()
    {
        var entities = await _projectNoteRepository.GetAllAsync();

        var projectnotes = entities.Select(ProjectNoteFactory.Create);
        return projectnotes;
    }
}
