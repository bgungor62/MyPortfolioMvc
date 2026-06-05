using Dapper;
using MyPortfolio.Models;
using Npgsql;

namespace MyPortfolio.Repositories.ProjectRepository
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<IEnumerable<Project>> GetActiveProjectAsync()
        {
            using var connection = new NpgsqlConnection(_connectionString);
            var sql = @"SELECT * FROM Projects WHERE IsActive=@IsActive";
            var result = await connection.QueryAsync<Project>(sql, new { IsActive = true });
            return result;
        }
    }
}
