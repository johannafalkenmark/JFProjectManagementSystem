using Data.Contexts;
using Data.Entities;


namespace Data.Repositories;
public class ProjectScheduleRepository(DataContext context) : BaseRepository<ProjectScheduleEntity>(context)

{
    private readonly DataContext _context = context;
}
