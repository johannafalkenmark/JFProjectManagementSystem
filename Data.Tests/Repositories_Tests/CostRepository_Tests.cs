using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class CostRepository_Tests
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
    public async Task GetCostsAsync_ShouldReturnAllCosts()
    {
        //Arrange
        var context = GetDataContext();
        context.Cost.AddRange(TestData.CostsEntities);
        context.ServiceType.AddRange(TestData.ServiceTypeEntities);
        await context.SaveChangesAsync();

        ICostRepository repository = new CostRepository(context);

        //Act

        var result = await repository.GetAllAsync();

        //Assert

        Assert.Equal(TestData.CostsEntities.Length, result.Count());
    }
}
