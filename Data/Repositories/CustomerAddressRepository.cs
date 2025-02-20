using Data.Contexts;
using Data.Entities;
namespace Data.Repositories;

public class CustomerAddressRepository(DataContext context) : BaseRepository<CustomerAddressEntity>(context)

{
    private readonly DataContext _context = context;
}
