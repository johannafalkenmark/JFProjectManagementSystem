﻿using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class TypeOfIndustryRepository_Tests
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
    public async Task GetTypeOfIndustriesAsync_ShouldReturnAllTypeOfIndustries()
    {
        //Arrange
        var context = GetDataContext();
        context.TypeOfIndustry.AddRange(TestData.TypeOfIndustryEntities);
        await context.SaveChangesAsync();

        ITypeOfIndustryRepository repository = new TypeOfIndustryRepository(context);

        //Act

        var result = await repository.GetAllAsync();

        //Assert

        Assert.Equal(TestData.TypeOfIndustryEntities.Length, result.Count());
    }
}