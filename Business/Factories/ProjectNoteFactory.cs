

using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class ProjectNoteFactory
{
    public static ProjectNoteEntity? Create(ProjectNoteRegistrationForm form) => form == null ? null : new()
    {
        Notes = form.Notes,
        
    };

    public static ProjectNote? Create(ProjectNoteEntity entity)

    {
        if (entity == null)
            return null;

        var projectnote = new ProjectNote()
        {
            Id = entity.Id,
          Notes = entity.Notes,


            Projects = []

        };



        return projectnote;
    }

}
