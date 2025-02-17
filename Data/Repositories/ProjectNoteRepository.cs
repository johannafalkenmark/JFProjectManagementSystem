using Data.Contexts;
using Data.Entities;


namespace Data.Repositories;

    public class ProjectNoteRepository(DataContext context) : BaseRepository<ProjectNoteEntity>(context)

    {
        private readonly DataContext _context = context;
    }


