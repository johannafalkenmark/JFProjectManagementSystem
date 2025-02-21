using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class CostService(ICostRepository costRepository) : ICostService
{
    private readonly ICostRepository _costRepository = costRepository;

    public async Task<IEnumerable<Cost>> GetCostsAsync()
    {
        var entities = await _costRepository.GetAllAsync();

        var costs = entities.Select(CostFactory.Create);
        return costs;
    }
}
