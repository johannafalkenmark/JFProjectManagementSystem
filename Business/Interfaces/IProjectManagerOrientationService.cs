using Business.Models;

namespace Business.Interfaces
{
    public interface IProjectManagerOrientationService
    {
        Task<IEnumerable<ProjectManagerOrientation>> GetProjectManagerOrientationsAsync();
    }
}