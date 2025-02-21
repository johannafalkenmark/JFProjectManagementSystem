

using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class ProjectManagerFactory
{
    public static ProjectManagerEntity? Create(ProjectManagerRegistrationForm form) => form == null ? null : new()
    {
        FirstName = form.FirstName,
        LastName = form.LastName,
        TypeOfOrientationId = form.ProjectManagerOrientationId

    };

    public static ProjectManager? Create(ProjectManagerEntity entity)

    {
        if (entity == null)
            return null;

        var projectmanager = new ProjectManager()
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,


            Projects = []
        };


        if (entity.TypeOfOrientation != null)
        {
            projectmanager.ProjectManagerOrientation = new ProjectManagerOrientation
            {
                Id = entity.TypeOfOrientation.Id,
                TypeOfOrientation = entity.TypeOfOrientation.TypeOfOrientation,

            };
        }


        return projectmanager;
    }

}
