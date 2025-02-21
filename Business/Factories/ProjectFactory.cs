using Business.Models;
using Data.Entities;


namespace Business.Factories;

public class ProjectFactory

{
    public static ProjectEntity? Create(ProjectRegistrationForm form) => form == null ? default : new()
    {
        ProjectName = form.ProjectName,
        
        CustomerId = form.CustomerId,

        ServiceTypeId = form.ServiceTypeId,

        ProjectManagerId = form.ProjectManagerId,

        StatusTypeId = form.StatusTypeId,

        UserId = form.UserId,

        ProjectNoteId = form.ProjectNoteId,

        ProjectScheduleId = form.ProjectScheduleId


    };

  
    public static Project? Create(ProjectEntity entity)
    { 
        if (entity == null)
            return null;

        var project = new Project
        {
            Id = entity.Id,
            ProjectName = entity.ProjectName,
            
        };

        if (entity.Customer != null)
        {
            project.Customer = new Customer
            {
                Id = entity.Customer.Id,
                CustomerName = entity.Customer.CustomerName,

            };
        }
        if (entity.ProjectManager != null)
        {
            project.ProjectManager = new ProjectManager
            {
                Id = entity.ProjectManager.Id,
                FirstName = entity.ProjectManager.FirstName,
                LastName = entity.ProjectManager.LastName,

            };
        }

        if (entity.ServiceType != null)
        {
            project.ServiceType = new ServiceType
            {
                Id = entity.ServiceType.Id,
                TypeName = entity.ServiceType.TypeName
            };
        }

        if (entity.StatusType != null)
        {
            project.StatusType = new StatusType
            {
                Id = entity.StatusType.Id,
                TypeName = entity.StatusType.TypeName
            };
        }

        if (entity.User != null)
        {
            project.User = new User
            {
                Id = entity.User.Id,
                FirstName = entity.User.FirstName,
                LastName = entity.User.LastName,
                Email = entity.User.Email
            };
        }

        if (entity.ProjectNote != null)
        {
            project.ProjectNote = new ProjectNote
            {
                Id = entity.ProjectNote.Id,
                Notes = entity.ProjectNote.Notes,

            };
        }


        if (entity.ProjectSchedule != null)
        {
            project.ProjectSchedule = new ProjectSchedule
            {
                Id = entity.ProjectSchedule.Id,
                StartDate = entity.ProjectSchedule.StartDate,
                EndDate = entity.ProjectSchedule.EndDate,

            };
        }

        return project;
    }
 

    public static ProjectEntity? Update(ProjectEntity entity, ProjectRegistrationForm form)
    {
        if (entity == null ||  form == null)
            return null;

        entity.ProjectName = form.ProjectName;
        entity.CustomerId = form.CustomerId;
        entity.ServiceTypeId = form.ServiceTypeId;
        entity.ProjectManagerId = form.ProjectManagerId;
        entity.StatusTypeId = form.StatusTypeId;
        entity.UserId = form.UserId;
        entity.ProjectNoteId = form.ProjectNoteId;
        entity.ProjectScheduleId = form.ProjectScheduleId;

        return entity;
    }

}
