using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class CustomerAddressService(ICustomerAddressRepository customerAddressRepository) : ICustomerAddressService
{
    private readonly ICustomerAddressRepository _customerAddressRepository = customerAddressRepository;

    public async Task<IEnumerable<CustomerAddress>> GetCustomerAddressAsync()
    {
        var entities = await _customerAddressRepository.GetAllAsync();

        var customeraddresses = entities.Select(CustomerAddressFactory.Create);
        return customeraddresses;
    }
}