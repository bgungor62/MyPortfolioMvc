using MyPortfolio.Models;

namespace MyPortfolio.Repositories
{
    public interface ITestimonialRepository : IGenericRepository<Testimonial>
    {
        Task<IEnumerable<Testimonial>> GetActiveTestimonialAsync();
    }
}
