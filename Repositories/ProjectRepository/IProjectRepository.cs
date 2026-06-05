using MyPortfolio.Models;

namespace MyPortfolio.Repositories.ProjectRepository
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        Task<IEnumerable<Project>> GetActiveProjectAsync();
    }
}
