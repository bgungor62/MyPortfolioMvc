
using Dapper;
using Npgsql;

namespace MyPortfolio.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly string _connectionString;
        private readonly string _tableName;
        public GenericRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") ??
                throw new InvalidOperationException("Connection string not found!");
            _tableName = typeof(T).Name + "s"; //project->projects
        }
        public Task<int> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using var connection = new NpgsqlConnection(_connectionString);
            var sql = $"SELECT * FROM {_tableName}";
            var result = await connection.QueryAsync<T>(sql);
            return result;
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            var sql = $"SELECT * FROM {_tableName} WHERE Id=@Id";
            var result = await connection.QueryFirstOrDefaultAsync<T>(sql, new { Id = id });
            return result;
        }

        public Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
