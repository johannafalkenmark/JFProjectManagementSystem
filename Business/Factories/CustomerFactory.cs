

using Business.Models;
using Data.Entities;

namespace Business.Factories;

//Upplagt här så att hela new instansieringen sker här, även för projects.
public class CustomerFactory
{
    public static CustomerEntity? Create(CustomerRegistrationForm form) => form == null ? null : new()
    {
        CustomerName = form.CustomerName,

        CustomerTypeId = form.CustomerTypeId,

        TypeOfIndustryId = form.TypeOfIndustryId,

        CustomerAddressId = form.CustomerAddressId,

    };

    public static Customer? Create(CustomerEntity entity)

    {
        if (entity == null)
            return null;

        var customer = new Customer()
        {
            Id = entity.Id,
            CustomerName = entity.CustomerName,

            Projects = []
        };

        if (entity.Projects != null)
        {
            var projects = new List<Project>();

            foreach (var project in entity.Projects)
                projects.Add(new Project
                {
                    Id = project.Id,


                });
            customer.Projects = projects;

        }

        if (entity.CustomerType != null)
        {
            customer.CustomerType = new CustomerType
            {
                Id = entity.CustomerType.Id,
                TypeName = entity.CustomerType.TypeName
            };
        }

        if (entity.TypeOfIndustry != null)
        {
            customer.TypeOfIndustry = new TypeOfIndustry
            {
                Id = entity.TypeOfIndustry.Id,
                TypeName = entity.TypeOfIndustry.TypeName
            };
        }


        if (entity.CustomerAddress != null)
        {
            customer.CustomerAddress = new CustomerAddress
            {
                Id = entity.CustomerAddress.Id,
                Address = entity.CustomerAddress.Address
            };
        }

        if (entity.CustomerReference != null)
        {
            customer.CustomerReference = new CustomerReference
            {
                Id = entity.CustomerReference.Id,
                Reference = entity.CustomerReference.Reference
            };
        }

        return customer;
    }

}
