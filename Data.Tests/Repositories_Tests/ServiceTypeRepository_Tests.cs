﻿

using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class ServiceTypeRepository_Tests
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
    public async Task GetServiceTypesAsync_ShouldReturnAllServiceTypes()
    {
        //Arrange
        var context = GetDataContext();
        context.ServiceType.AddRange(TestData.ServiceTypeEntities);
        context.ServiceCategory.AddRange(TestData.ServiceCategoryEntities);
        await context.SaveChangesAsync();

        IServiceTypeRepository repository = new ServiceTypeRepository(context);

        //Act

        var result = await repository.GetAllAsync();

        //Assert

        Assert.Equal(TestData.ServiceTypeEntities.Length, result.Count());
    }
}
