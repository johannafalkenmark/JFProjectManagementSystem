using Data.Contexts;
using Data.Entities;

namespace Data.Repositories;

public class TypeOfIndustryRepository(DataContext context) : BaseRepository<TypeOfIndustryEntity>(context)

{
    private readonly DataContext _context = context;
}

