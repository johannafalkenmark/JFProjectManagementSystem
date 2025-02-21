
using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

public class ProjectManagerOrientationRepository(DataContext context) : BaseRepository<ProjectManagerOrientationEntity>(context), IProjectManagerOrientationRepository

{
    private readonly DataContext _context = context;
}

