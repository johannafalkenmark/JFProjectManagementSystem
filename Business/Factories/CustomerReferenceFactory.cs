

using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class CustomerReferenceFactory
{
    public static CustomerReferenceEntity? Create(CustomerReferenceRegistrationForm form) => form == null ? null : new()
    {
        Reference = form.Reference,

    };

    public static CustomerReference? Create(CustomerReferenceEntity entity)

    {
        if (entity == null)
            return null;

        var customerreference = new CustomerReference()
        {
            Id = entity.Id,
            Reference = entity.Reference,

        };

        return customerreference;
    }

}
