using Business.Models;

namespace Business.Interfaces
{
    public interface IProjectScheduleService
    {
        Task<IEnumerable<ProjectSchedule>> GetProjectSchedulesAsync();
    }
}