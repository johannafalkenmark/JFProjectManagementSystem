using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class CustomerTypeRepository_Tests
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
    public async Task GetCustomerTypeAsync_ShouldReturnAllCustomerTypes()
    {
        //Arrange
        var context = GetDataContext();
        context.CustomerType.AddRange(TestData.CustomerTypesEntities);
        await context.SaveChangesAsync();

        ICustomerTypeRepository repository = new CustomerTypeRepository(context);

        //Act

        var result = await repository.GetAllAsync();

        //Assert

        Assert.Equal(TestData.CustomerTypesEntities.Length, result.Count());
    }
}