using DesafioAeC.Automation.Domain.Entities;

namespace DesafioAeC.AluraRPA.Data.Repositories
{
    public interface ISearchResultRepository
    {
        Task AddResultsBulkAsync(List<SearchResult> results);
    }
}
