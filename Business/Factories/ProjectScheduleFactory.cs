

using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class ProjectScheduleFactory
{
    public static ProjectScheduleEntity? Create(ProjectScheduleRegistrationForm form) => form == null ? null : new()
    {
        StartDate = form.StartDate,
        EndDate = form.EndDate,

    };

    public static ProjectSchedule? Create(ProjectScheduleEntity entity)

    {
        if (entity == null)
            return null;

        var projectschedule = new ProjectSchedule()
        {
            Id = entity.Id,
            StartDate = entity.StartDate,
            EndDate = entity.EndDate,


            Projects = []

        };



        return projectschedule;
    }

}
