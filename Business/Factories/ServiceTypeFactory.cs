

using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class ServiceTypeFactory
{
    public static ServiceTypeEntity? Create(ServiceTypeRegistrationForm form) => form == null ? null : new()
    {
        TypeName = form.TypeName,
     

    };

    public static ServiceType? Create(ServiceTypeEntity entity)

    {
        if (entity == null)
            return null;

        var servicetype = new ServiceType()
        {
            Id = entity.Id,
            TypeName = entity.TypeName,

            Projects = []
        };

        if (entity.ServiceCategory != null)
        {
            servicetype.ServiceCategory = new ServiceCategory
            {
                Id = entity.ServiceCategory.Id,
                CategeoryName = entity.ServiceCategory.CategoryName
            };
        }

        return servicetype;
    }

}
