using MyPortfolio.Models;

namespace MyPortfolio.Repositories.AboutRepository
{
    public class AboutRepository : GenericRepository<About>, IAboutRepository
    {
        public AboutRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
