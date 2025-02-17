using Data.Contexts;
using Data.Entities;

namespace Data.Repositories;

public class ServiceCategoryRepository(DataContext context) : BaseRepository<ServiceCategoryEntity>(context)

{
    private readonly DataContext _context = context;
}


