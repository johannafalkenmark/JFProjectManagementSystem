using Business.Models;

namespace Business.Interfaces
{
    public interface ICustomerAddressService
    {
        Task<IEnumerable<CustomerAddress>> GetCustomerAddressAsync();
    }
}