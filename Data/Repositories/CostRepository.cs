using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

public class CostRepository(DataContext context) : BaseRepository<CostEntity>(context), ICostRepository
{
private readonly DataContext _context = context;
}

