

using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class TypeOfIndustryFactory
{
    public static TypeOfIndustryEntity? Create(TypeOfIndustryRegistrationForm form) => form == null ? null : new()
    {
        TypeName = form.TypeName,

    };

    public static TypeOfIndustry? Create(TypeOfIndustryEntity entity)

    {
        if (entity == null)
            return null;

        var typeofindustry = new TypeOfIndustry()
        {
            Id = entity.Id,
            TypeName = entity.TypeName,

            Customers = []

        };



        return typeofindustry;
    }

}
