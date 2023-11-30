using DesafioAeC.Automation.Domain.Interfaces;
using DesafioAeC.Automation.Services;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static async void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddTransient<ISearchService, SearchService>()
            .BuildServiceProvider();

        try
        {
            var searchService = serviceProvider.GetService<ISearchService>();
            ArgumentNullException.ThrowIfNull(searchService);

            Console.WriteLine("Inicializando RPA com Selenium...");
            Console.WriteLine("Esta aplicação utilizará o browser Firefox.");
            
            string? query;
            do
            {
                Console.WriteLine("Por favor, insira o termo de busca que deseja: ");
                query = Console.ReadLine();

            } while (string.IsNullOrEmpty(query));
            
            var results = await searchService.SearchAsync(query);

            foreach (var result in results)
            {
                Console.WriteLine($"Titulo: {result.Titulo}");
                Console.WriteLine($"Professor: {result.Professor}");
                Console.WriteLine($"Carga Horária: {result.CargaHoraria}");
                Console.WriteLine($"Descrição: {result.Descricao}");
                Console.WriteLine("--------------------------------");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Um erro ocorreu durante o processo. {ex.Message}");
        }
    }
}