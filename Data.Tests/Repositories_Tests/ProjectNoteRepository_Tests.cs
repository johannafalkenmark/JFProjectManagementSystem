

using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class ProjectNoteRepository_Tests
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
    public async Task GetProjectNotesAsync_ShouldReturnAllProjectNotes()
    {
        //Arrange
        var context = GetDataContext();
        context.ProjectNote.AddRange(TestData.ProjectNotesEntities);
        await context.SaveChangesAsync();

        IProjectNoteRepository repository = new ProjectNoteRepository(context);

        //Act

        var result = await repository.GetAllAsync();

        //Assert

        Assert.Equal(TestData.ProjectNotesEntities.Length, result.Count());
    }

}
