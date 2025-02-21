using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class CustomerReferenceRepository_Tests
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
    public async Task GetCustomerReferencesAsync_ShouldReturnAllCustomerReferences()
    {
        //Arrange
        var context = GetDataContext();
        context.CustomerReference.AddRange(TestData.CustomerReferencesEntities);
        await context.SaveChangesAsync();

        ICustomerReferenceRepository repository = new CustomerReferenceRepository(context);

        //Act

        var result = await repository.GetAllAsync();

        //Assert

        Assert.Equal(TestData.CustomerReferencesEntities.Length, result.Count());
    }




}
