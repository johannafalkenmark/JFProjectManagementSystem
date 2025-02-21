

using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class UserFactory
{
    public static UserEntity? Create(UserRegistrationForm form) => form == null ? null : new()
    {
        FirstName = form.FirstName,
        LastName = form.LastName,
Email = form.Email   

    };

    public static User? Create(UserEntity entity)

    {
        if (entity == null)
            return null;

        var user = new User()
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,



            Projects = []

        };

  
        
        return user;
    }

}
