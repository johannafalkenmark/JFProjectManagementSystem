using Business.Models;

namespace Business.Interfaces
{
    public interface ITypeOfIndustryService
    {
        Task<IEnumerable<TypeOfIndustry>> GetTypeOfIndustriesAsync();
    }
}