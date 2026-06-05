using MyPortfolio.Models;

namespace MyPortfolio.Repositories.SkillRepository
{
    public class SkillRepository : GenericRepository<Skill>, ISkillRepository
    {
        public SkillRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
