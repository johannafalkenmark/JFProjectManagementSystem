using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class TypeOfIndustryService(ITypeOfIndustryRepository typeOfIndustryRepository) : ITypeOfIndustryService
{
    private readonly ITypeOfIndustryRepository _typeOfIndustryRepository = typeOfIndustryRepository;

    public async Task<IEnumerable<TypeOfIndustry>> GetTypeOfIndustriesAsync()
    {
        var entities = await _typeOfIndustryRepository.GetAllAsync();

        var typeofindustries = entities.Select(TypeOfIndustryFactory.Create);
        return typeofindustries;
    }
}


