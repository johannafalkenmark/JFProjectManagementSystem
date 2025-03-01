

using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class ProjectRepository_Tests
{
    private DataContext GetDataContext()
    {
        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new DataContext(options);
        context.Database.EnsureCreated();
        return context;
    }


    [Fact]

    public async Task GetAllAsync_ShouldReturnAllProjects()
    {
        var context = GetDataContext();

        context.Projects.AddRange(TestData.ProjectsEntities);
        context.Customers.AddRange(TestData.CustomerEntities);
        context.ProjectManager.AddRange(TestData.ProjectManagersEntities);
        context.ProjectSchedule.AddRange(TestData.ProjectSchedulesEntities);
        context.StatusType.AddRange(TestData.StatusTypeEntities);
        context.ServiceType.AddRange(TestData.ServiceTypeEntities);
        context.User.AddRange(TestData.UsersEntities);
        context.ProjectNote.AddRange(TestData.ProjectNotesEntities);
   
        
        await context.SaveChangesAsync();

        IProjectRepository repository = new ProjectRepository(context);

        //Act

        var result = await repository.GetAllAsync();

        //Assert
        Assert.Equal(TestData.ProjectsEntities.Length, result.Count());
    }



    [Fact]

    public async Task GetAsync_ShouldReturnProject()
    {
        var context = GetDataContext();

        context.Projects.AddRange(TestData.ProjectsEntities);
        context.Customers.AddRange(TestData.CustomerEntities);
        context.ProjectManager.AddRange(TestData.ProjectManagersEntities);
        context.ProjectSchedule.AddRange(TestData.ProjectSchedulesEntities);
        context.StatusType.AddRange(TestData.StatusTypeEntities);
        context.ServiceType.AddRange(TestData.ServiceTypeEntities);
        context.User.AddRange(TestData.UsersEntities);
        context.ProjectNote.AddRange(TestData.ProjectNotesEntities);
        await context.SaveChangesAsync();
    

        IProjectRepository repository = new ProjectRepository(context);

        //Act

        var result = await repository.GetAsync(x => x.Id == 1);

        //Assert
        Assert.Equal(1, result!.Id);
    }

}

