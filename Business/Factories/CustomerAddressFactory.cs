

using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class CustomerAddressFactory
{
    public static CustomerAddressEntity? Create(CustomerAddressRegistrationForm form) => form == null ? null : new()
    {
        Address = form.Address,

    };

    public static CustomerAddress? Create(CustomerAddressEntity entity)

    {
        if (entity == null)
            return null;

        var customeraddress = new CustomerAddress()
        {
            Id = entity.Id,
            Address = entity.Address,

  

        };



        return customeraddress;
    }

}