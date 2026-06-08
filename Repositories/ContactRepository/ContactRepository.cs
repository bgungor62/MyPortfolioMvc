using Dapper;
using MyPortfolio.Models;
using Npgsql;

namespace MyPortfolio.Repositories.ContactRepository
{
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public ContactRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IEnumerable<Contact>> GetUnreadMessageAsync()
        {
            using var connection = new NpgsqlConnection(_connectionString);
            var sql = "SELECT * FROM Contacts WHERE IsRead = @IsRead ORDER BY CreatedAt DESC";
            var result = await connection.QueryAsync<Contact>(sql, new { IsRead = false });
            return result;
        }
    }
}
