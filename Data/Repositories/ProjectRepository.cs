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
        var entities = await _context.Projects.Include(x => x.ProjectManager).ToListAsync();

        return entities!;

    }

    //Exempel hämta en sak med statustype:
    public override async Task<ProjectEntity> GetAsync(Expression<Func<ProjectEntity, bool>> expression)
    {
        if (expression == null)
            return null!;

        return await _context.Projects
            .Include(x => x.StatusType)
            .Include(x => x.ProjectManager)
            .FirstOrDefaultAsync(expression) ?? null!; 
   

    }


    //Nedan genererades via interfacet (där hade jag skapat den här metoden nedan:)
    public async Task<IEnumerable<ProjectEntity>> GetAllProjectsWithStatusTypeAsync()
    {
        var entities = await _context.Projects.Include(x => x.StatusType).ToListAsync();
        return entities!;
    }
}

