using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class ServiceTypeRepository(DataContext context) : BaseRepository<ServiceTypeEntity>(context), IServiceTypeRepository

{
    private readonly DataContext _context = context;

    public override async Task<IEnumerable<ServiceTypeEntity>> GetAllAsync()
    {



        var entities = await _context.ServiceType
            .Include(x => x.ServiceCategory)
         
            .ToListAsync();

        return entities!;

    }
}
