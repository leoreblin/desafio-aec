using DesafioAeC.Automation.Data;
using DesafioAeC.Automation.Domain.Entities;

namespace DesafioAeC.AluraRPA.Data.Repositories
{
    public class SearchResultRepository : ISearchResultRepository
    {
        private readonly AppDbContext _context;

        public SearchResultRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddResultsBulkAsync(List<SearchResult> results)
        {
            _context.Results.AddRange(results);
            await _context.SaveChangesAsync();
        }
    }
}
