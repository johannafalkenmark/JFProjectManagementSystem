using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

public class ServiceCategoryRepository(DataContext context) : BaseRepository<ServiceCategoryEntity>(context), IServiceCategoryRepository

{
    private readonly DataContext _context = context;
}


