

using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class StatusTypeFactory
{
    public static StatusTypeEntity? Create(StatusTypeRegistrationForm form) => form == null ? null : new()
    {
        TypeName = form.TypeName,
       
    };

    public static StatusType? Create(StatusTypeEntity entity)

    {
        if (entity == null)
            return null;

        var statustype = new StatusType()
        {
            Id = entity.Id,
            TypeName = entity.TypeName,

            Projects = []

        };



        return statustype;
    }

}
