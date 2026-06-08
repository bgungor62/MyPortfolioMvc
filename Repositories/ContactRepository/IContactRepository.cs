using MyPortfolio.Models;

namespace MyPortfolio.Repositories.ContactRepository
{
    public interface IContactRepository : IGenericRepository<Contact>
    {
        Task<IEnumerable<Contact>> GetUnreadMessageAsync();
    }
}
