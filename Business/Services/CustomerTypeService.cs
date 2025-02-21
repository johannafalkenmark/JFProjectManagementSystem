using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class CustomerTypeService(ICustomerTypeRepository customerTypeRepository) : ICustomerTypeService
{
    private readonly ICustomerTypeRepository _customerTypeRepository = customerTypeRepository;

    public async Task<IEnumerable<CustomerType>> GetCustomerTypesAsync()
    {
        var entities = await _customerTypeRepository.GetAllAsync();

        var customertypes = entities.Select(CustomerTypeFactory.Create);
        return customertypes;
    }
}
