using DesafioAeC.Automation.Domain.Entities;

namespace DesafioAeC.Automation.Data
{
    public class CourseRepository
    {
        private readonly AppDbContext _context;

        public CourseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddResultAsync(SearchResult result)
        {
            _context.Results.Add(result);
            await _context.SaveChangesAsync();
        }

    }
}
