using Business.Models;

namespace Business.Interfaces
{
    public interface IProjectService
    {
        Task<bool> CreateProjectAsync(ProjectRegistrationForm form);
        Task<bool> DeleteProjectAsync(int projectId);
        Task<IEnumerable<Project>> GetProjectsAsync();
        Task<Project?> GetSingleProjectAsync(int projectId);
        Task<bool> UpdateProjectAsync(int projectId, ProjectRegistrationForm form);
    }
}