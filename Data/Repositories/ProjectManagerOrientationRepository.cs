
using Data.Contexts;
using Data.Entities;

namespace Data.Repositories;

public class ProjectManagerOrientationRepository(DataContext context) : BaseRepository<ProjectManagerOrientationEntity>(context)

{
    private readonly DataContext _context = context;
}

