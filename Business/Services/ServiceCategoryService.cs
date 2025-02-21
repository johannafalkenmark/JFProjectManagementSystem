using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class ServiceCategoryService(IServiceCategoryRepository serviceCategoryRepository) : IServiceCategoryService
{
    private readonly IServiceCategoryRepository _serviceCategoryRepository = serviceCategoryRepository;

    public async Task<IEnumerable<ServiceCategory>> GetServiceCategoriesAsync()
    {
        var entities = await _serviceCategoryRepository.GetAllAsync();

        var servicecategories = entities.Select(ServiceCategoryFactory.Create);
        return servicecategories;
    }
}