

using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class ProjectManagerOrientationFactory
{
    public static ProjectManagerOrientationEntity? Create(ProjectManagerOrientationRegistrationForm form) => form == null ? null : new()
    {
        TypeOfOrientation = form.TypeOfOrientation,

    };

    public static ProjectManagerOrientation? Create(ProjectManagerOrientationEntity entity)

    {
        if (entity == null)
            return null;

        var projectmanagerorientation = new ProjectManagerOrientation()
        {
            Id = entity.Id,
            TypeOfOrientation = entity.TypeOfOrientation,
           



            ProjectManagers = []

        };



        return projectmanagerorientation;
    }

}
