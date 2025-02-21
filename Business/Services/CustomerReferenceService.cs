using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class CustomerReferenceService(ICustomerReferenceRepository customerReferenceRepository) : ICustomerReferenceService
{
    private readonly ICustomerReferenceRepository _customerReferenceRepository = customerReferenceRepository;

    public async Task<IEnumerable<CustomerReference>> GetCustomerReferencesAsync()
    {
        var entities = await _customerReferenceRepository.GetAllAsync();

        var customerreferences = entities.Select(CustomerReferenceFactory.Create);
        return customerreferences;
    }
}
