using Business.Models;

namespace Business.Interfaces
{
    public interface IServiceTypeService
    {
        Task<IEnumerable<ServiceType>> GetServiceTypesAsync();
    }
}