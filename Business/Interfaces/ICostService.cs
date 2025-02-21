using Business.Models;

namespace Business.Interfaces
{
    public interface ICostService
    {
        Task<IEnumerable<Cost>> GetCostsAsync();
    }
}