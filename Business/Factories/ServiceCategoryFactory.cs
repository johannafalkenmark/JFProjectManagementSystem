

using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class ServiceCategoryFactory
{
    public static ServiceCategoryEntity? Create(ServiceCategoryRegistrationForm form) => form == null ? null : new()
    {
        CategoryName = form.CategeoryName,

    };

    public static ServiceCategory? Create(ServiceCategoryEntity entity)

    {
        if (entity == null)
            return null;

        var servicecategory = new ServiceCategory()
        {
            Id = entity.Id,
            CategeoryName = entity.CategoryName,

        };

        return servicecategory;
    }

}
