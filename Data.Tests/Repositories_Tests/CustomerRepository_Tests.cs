﻿using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class CustomerRepository_Tests
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
    public async Task GetCustomersAsync_ShouldReturnAllCustomers()
    {
        //Arrange
        var context = GetDataContext();
        context.Customers.AddRange(TestData.CustomerEntities);
      context.CustomerType.AddRange(TestData.CustomerTypesEntities);
      context.TypeOfIndustry.AddRange(TestData.TypeOfIndustryEntities);
      context.CustomerAddress.AddRange(TestData.CustomerAddressEntities);
      context.CustomerReference.AddRange(TestData.CustomerReferencesEntities);
        await context.SaveChangesAsync();

        ICustomerRepository repository = new CustomerRepository(context);

        //Act

        var result = await repository.GetAllAsync();

        //Assert

        Assert.Equal(TestData.CustomerEntities.Length, result.Count());
    }
}

