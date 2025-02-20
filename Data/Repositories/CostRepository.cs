using Data.Contexts;
using Data.Entities;

namespace Data.Repositories;

public class CostRepository(DataContext context) : BaseRepository<CostEntity>(context)
{
private readonly DataContext _context = context;
}

