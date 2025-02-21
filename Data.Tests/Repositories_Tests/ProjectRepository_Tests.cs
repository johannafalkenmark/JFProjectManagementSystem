

//using Data.Contexts;
//using Data.Interfaces;
//using Data.Repositories;
//using Data.Tests.SeedData;
//using Microsoft.EntityFrameworkCore;

//namespace Data.Tests.Repositories_Tests;

//public class ProjectRepository_Tests
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
//    public async Task GetProjectsAsync_ShouldReturnAllClients()
//    {
//        //Arrange
//        var context = GetDataContext();
        

//        context.Customers.AddRange(TestData.CustomerTestData);
//        context.ProjectManager.AddRange(TestData.CustomerTestData);
//        context.ProjectNote.AddRange(TestData.CustomerTestData);
//        context.ProjectSchedule.AddRange(TestData.CustomerTestData);
//        context.StatusType.AddRange(TestData.CustomerTestData);
//        context.Customers.AddRange(TestData.CustomerTestData);
//        //Lägg till fler saker här om det är beroemdem
//        await context.SaveChangesAsync();

//        IProjectRepository repository = new ProjectRepository(context);

//        var projectEntity = TestData.ProjectsEntities[0];



//        //Act

//        var result = await repository.CreateAsync(projectEntity);

//        //Assert
//        Assert.NotEqual(0, result!.Id);
//    }

//    [Fact]

//    public async Task GetAllAsync_ShouldReturnAllProjects()
//    {
//        var context = GetDataContext();

//        //Justera till rätt entititer nedan
//        context.Customers.AddRange(TestData.CustomerTestData);
//        context.ProjectManager.AddRange(TestData.CustomerTestData);
//        context.ProjectNote.AddRange(TestData.CustomerTestData);
//        context.ProjectSchedule.AddRange(TestData.CustomerTestData);
//        context.StatusType.AddRange(TestData.CustomerTestData);
//        context.Customers.AddRange(TestData.CustomerTestData);
//        //Lägg till fler saker här om det är beroemdem
//        await context.SaveChangesAsync();

//        IProjectRepository repository = new ProjectRepository(context);

//        //Act

//        var result = await repository.GetAllAsync();

//        //Assert
//        Assert.Equal(TestData.ProjectsEntities.Length, result.Count());  
//    }



//    [Fact]

//    public async Task GetAsync_ShouldReturnProject()
//    {
//        var context = GetDataContext();

//        context.Customers.AddRange(TestData.CustomerTestData);
//        context.ProjectManager.AddRange(TestData.CustomerTestData);
//        context.ProjectNote.AddRange(TestData.CustomerTestData);
//        context.ProjectSchedule.AddRange(TestData.CustomerTestData);
//        context.StatusType.AddRange(TestData.CustomerTestData);
//        context.Customers.AddRange(TestData.CustomerTestData);
//        //Lägg till fler saker här om det är beroemdem
//        await context.SaveChangesAsync();

//        IProjectRepository repository = new ProjectRepository(context);

//        //Act

//        var result = await repository.GetAsync(x => x.Id == 1);

//        //Assert
//        Assert.Equal(1, result!.Id);
//    }

//}
