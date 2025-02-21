

using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class CostFactory
{
    public static CostEntity? Create(CostRegistrationForm form) => form == null ? null : new()
    {
        Cost = form.CostAmount,
       
    };

    public static Cost? Create(CostEntity entity)

    {
        if (entity == null)
            return null;

        var cost = new Cost()
        {
            Id = entity.Id,
           CostAmount = entity.Cost,

        };

        return cost;
    }

}
