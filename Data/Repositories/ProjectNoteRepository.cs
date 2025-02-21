using Data.Contexts;
using Data.Entities;
using Data.Interfaces;


namespace Data.Repositories;

    public class ProjectNoteRepository(DataContext context) : BaseRepository<ProjectNoteEntity>(context), IProjectNoteRepository

    {
        private readonly DataContext _context = context;
    }


