using Business.Models;

namespace Business.Interfaces
{
    public interface ICustomerReferenceService
    {
        Task<IEnumerable<CustomerReference>> GetCustomerReferencesAsync();
    }
}