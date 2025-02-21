using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;
using Data.Repositories;
using System.Diagnostics;

namespace Business.Services;

public class ServiceTypeService(IServiceTypeRepository serviceTypeRepository, IServiceCategoryRepository serviceCategoryRepository) : IServiceTypeService
{
    private readonly IServiceTypeRepository _serviceTypeRepository = serviceTypeRepository;
    private readonly IServiceCategoryRepository _serviceCategoryRepository = serviceCategoryRepository;

    public async Task<IEnumerable<ServiceType>> GetServiceTypesAsync()
    {
        try
        {
            var entities = await _serviceTypeRepository.GetAllAsync();

            var servicetypes = entities.Select(ServiceTypeFactory.Create);
            return servicetypes;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return null;
        }
        }
}
