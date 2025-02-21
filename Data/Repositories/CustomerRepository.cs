using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Data.Repositories;

public class CustomerRepository(DataContext context) : BaseRepository<CustomerEntity>(context), ICustomerRepository

{
    private readonly DataContext _context = context;


    public override async Task<IEnumerable<CustomerEntity>> GetAllAsync()
    {

   

        var entities = await _context.Customers
            .Include(x => x.CustomerType)
            .Include(x => x.TypeOfIndustry)
            .Include(x => x.CustomerAddress)
            .Include(x => x.CustomerReference)

        
            .ToListAsync();

        return entities!;

    }

    public override async Task<CustomerEntity?> GetAsync(Expression<Func<CustomerEntity, bool>> expression)
    {
        if (expression == null)
            return null!;

        return await _context.Customers
            .Include(x => x.CustomerType)
            .Include(x => x.TypeOfIndustry)
            .Include(x => x.CustomerAddress)
            .Include(x => x.CustomerReference)
            .Include(x => x.Projects)
            .FirstOrDefaultAsync(expression) ?? null!;


    }


}
