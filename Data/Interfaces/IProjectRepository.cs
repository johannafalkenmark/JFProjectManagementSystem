
using Data.Entities;

namespace Data.Interfaces
{
    public interface IProjectRepository : IBaseRepository<ProjectEntity>
    {

        //Utökar interfacet så kan jag även gör utsvävningar i tillhörande repository:

        Task<IEnumerable<ProjectEntity>> GetAllProjectsWithStatusTypeAsync();
    }
}
