using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;
using Data.Repositories;

namespace Business.Services;

public class CustomerService(ICustomerRepository customerRepository, ICustomerTypeRepository customerTypeRepository, ITypeOfIndustryRepository typeOfIndustryRepository, ICustomerAddressRepository customerAddressRepository, ICustomerReferenceRepository customerReferenceRepository) : ICustomerService
{
    private readonly ICustomerRepository _customerRepository = customerRepository;
    private readonly ICustomerTypeRepository _customerTypeRepository = customerTypeRepository;
    private readonly ITypeOfIndustryRepository _typeOfIndustryRepository = typeOfIndustryRepository;
    private readonly ICustomerAddressRepository _customerAddressRepository = customerAddressRepository;
    private readonly ICustomerReferenceRepository _customerReferenceRepository = customerReferenceRepository;

    public async Task<IEnumerable<Customer>> GetCustomersAsync()
    {

        //lägg in if sats if null samt try catch

       
        var entities = await _customerRepository.GetAllAsync();
      
        var customers = entities.Select(CustomerFactory.Create);
        
        return customers;
    }
}
