using Business.Models;

namespace Business.Interfaces
{
    public interface IProjectNoteService
    {
        Task<IEnumerable<ProjectNote>> GetProjectNotesAsync();
    }
}