

using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class ProjectManagerOrientationRepository_Tests
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
    public async Task GetProjectManagerOrientationsAsync_ShouldReturnAllProjectManagerOrientations()
    {
        //Arrange
        var context = GetDataContext();
        context.ProjectManagerOrientation.AddRange(TestData.ProjectManagerOrientationsEntities);
        await context.SaveChangesAsync();

        IProjectManagerOrientationRepository repository = new ProjectManagerOrientationRepository(context);

        //Act

        var result = await repository.GetAllAsync();

        //Assert

        Assert.Equal(TestData.ProjectManagerOrientationsEntities.Length, result.Count());
    }




}