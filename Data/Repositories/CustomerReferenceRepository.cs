using Data.Contexts;
using Data.Entities;

namespace Data.Repositories;

public class CustomerReferenceRepository(DataContext context) : BaseRepository<CustomerReferenceEntity>(context)

{
    private readonly DataContext _context = context;
}
