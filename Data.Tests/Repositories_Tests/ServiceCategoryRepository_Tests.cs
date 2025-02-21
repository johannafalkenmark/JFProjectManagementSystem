

using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class ServiceCategoryRepository_Tests
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
    public async Task GetServiceCategoriesAsync_ShouldReturnAllServiceCategories()
    {
        //Arrange
        var context = GetDataContext();
        context.ServiceCategory.AddRange(TestData.ServiceCategoryEntities);
        await context.SaveChangesAsync();

        IServiceCategoryRepository repository = new ServiceCategoryRepository(context);

        //Act

        var result = await repository.GetAllAsync();

        //Assert

        Assert.Equal(TestData.ServiceCategoryEntities.Length, result.Count());
    }
}