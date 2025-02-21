

using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class CustomerTypeFactory
{
    public static CustomerTypeEntity? Create(CustomerTypeRegistrationForm form) => form == null ? null : new()
    {
        TypeName = form.TypeName,

    };

    public static CustomerType? Create(CustomerTypeEntity entity)

    {
        if (entity == null)
            return null;

        var customertype = new CustomerType()
        {
            Id = entity.Id,
            TypeName = entity.TypeName,

            Customers = []

        };



        return customertype;
    }

}
