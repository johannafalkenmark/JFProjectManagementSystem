using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;
public class ProjectRepository(DataContext context) : BaseRepository<ProjectEntity>(context), IProjectRepository
{

    //Instanserar datacontext om behöver göra modifieringar
    private readonly DataContext _context = context;

    //TVÅ EXEMPEL NEDAN HUR MAN KAN UTÖKA:
    //Exempel på Override i metoderna: om tex vill skicka med något med entiteten, skickar med project manager nedan etc

    public override async Task<IEnumerable<ProjectEntity>> GetAllAsync()
    {

        //LÄgg in select om vi bara vill välja exakt vad vi ska ha ut - prestandaoptimering eager loading, behöver då skapa nytt objekt. Include är join satser. skickar med allt lazy loading.
        //.Where innebär om jag vill hämta just tex rolename som är x
        //.Select om vill välja bara specifika delar i objektet
        
        var entities = await _context.Projects
            .Include(x => x.Customer)
            .Include(x => x.ProjectManager)
            .Include(x => x.ServiceType)
            .Include(x => x.StatusType)
            .Include(x => x.User)
            .Include(x => x.ProjectSchedule)
            .Include(x => x.ProjectNote)
            .ToListAsync();

        return entities!;

    }

    public override async Task<ProjectEntity?> GetAsync(Expression<Func<ProjectEntity, bool>> expression)
    {
        if (expression == null)
            return null!;

        return await _context.Projects
           .Include(x => x.Customer)
            .Include(x => x.ProjectManager)
            .Include(x => x.ServiceType)
            .Include(x => x.StatusType)
            .Include(x => x.User)
            .Include(x => x.ProjectSchedule)
            .Include(x => x.ProjectNote)
            .FirstOrDefaultAsync(expression) ?? null!; 
   

    }


    //Nedan genererades via interfacet (där hade jag skapat den här metoden nedan:)
    public async Task<IEnumerable<ProjectEntity>> GetAllProjectsWithStatusTypeAsync()
    {
        var entities = await _context.Projects.Include(x => x.StatusType).ToListAsync();
        return entities!;
    }
}

