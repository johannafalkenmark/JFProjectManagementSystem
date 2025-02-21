using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

public class TypeOfIndustryRepository(DataContext context) : BaseRepository<TypeOfIndustryEntity>(context), ITypeOfIndustryRepository

{
    private readonly DataContext _context = context;
}

