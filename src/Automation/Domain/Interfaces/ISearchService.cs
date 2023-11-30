using DesafioAeC.Automation.Domain.Entities;

namespace DesafioAeC.Automation.Domain.Interfaces
{
    public interface ISearchService
    {
        Task<List<SearchResult>> SearchAsync(string query);
    }
}
