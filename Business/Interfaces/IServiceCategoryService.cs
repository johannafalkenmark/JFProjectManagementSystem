using Business.Models;

namespace Business.Interfaces
{
    public interface IServiceCategoryService
    {
        Task<IEnumerable<ServiceCategory>> GetServiceCategoriesAsync();
    }
}