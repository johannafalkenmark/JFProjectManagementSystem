using Data.Contexts;
using Data.Entities;

namespace Data.Repositories;

public class ProjectManagerRepository(DataContext context) : BaseRepository<ProjectManagerEntity>(context)

{
    private readonly DataContext _context = context;
}

