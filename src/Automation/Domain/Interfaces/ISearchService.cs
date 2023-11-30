using DesafioAeC.AluraRPA.Domain.Abstractions;
using DesafioAeC.Automation.Domain.Entities;

namespace DesafioAeC.Automation.Domain.Interfaces
{
    public interface ISearchService
    {
        Task OpenBrowser(string url);
        Task<Result<List<SearchResult>>> SearchAsync(string query);
    }
}
