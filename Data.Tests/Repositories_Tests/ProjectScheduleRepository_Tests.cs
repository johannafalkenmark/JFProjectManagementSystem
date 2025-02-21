using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

//public class ProjectScheduleRepository_Tests
//{

//    private DataContext GetDataContext()
//    {
//        var options = new DbContextOptionsBuilder<DataContext>()
//            .UseInMemoryDatabase(Guid.NewGuid().ToString())
//            .Options;

//        var context = new DataContext(options);
//        context.Database.EnsureCreated();
//        return context;
//    }

//    [Fact]
//    public async Task GetProjectSchedulesAsync_ShouldReturnAllProjectSchedules()
//    {
//        //Arrange
//        var context = GetDataContext();
//        context.ProjectSchedule.AddRange(TestData.ProjectSchedulesEntities);
//        await context.SaveChangesAsync();

//        IProjectScheduleRepository repository = new ProjectScheduleRepository(context);

//        //Act

//        var result = await repository.GetAllAsync();

//        //Assert

//        Assert.Equal(TestData.ProjectSchedulesEntities.Length, result.Count());
//    }
//}