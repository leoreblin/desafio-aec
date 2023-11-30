using DesafioAeC.AluraRPA.Extensions;
using DesafioAeC.Automation.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

class Program
{
    public static async Task Main(string[] args)
    {
        var builder = new HostBuilder()
            .ConfigureServices(services => services.ConfiureServices());

        var host = builder.Build();

        try
        {
            var searchService = host.Services.GetRequiredService<ISearchService>();
            ArgumentNullException.ThrowIfNull(searchService);

            Console.WriteLine("Inicializando RPA com Selenium...");
            Console.WriteLine("Esta aplicação utilizará o browser Firefox.");

            await searchService.OpenBrowser("https://www.alura.com.br");
            Thread.Sleep(1000);

            string query = "C#";

            Console.WriteLine($"Termo de pesquisa para este teste automatizado: {query}");

            var result = await searchService.SearchAsync(query);

            if (result.IsFailure)
            {
                Console.WriteLine(result.ErrorMessage);
            }

            Console.WriteLine("Processo de RPA concluído com sucesso.");
            if (result.Value is not null)
            {
                Console.WriteLine("Abaixo estão os registros encontrados:\n");
                foreach (var item in result.Value)
                {
                    Console.WriteLine($"Título: {item.Titulo}");
                    Console.WriteLine($"Professor: {item.Professor}");
                    Console.WriteLine($"Carga Horária: {item.CargaHoraria}");
                    Console.WriteLine($"Descrição: {item.Descricao}");
                    Console.WriteLine("--------------------------------------");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Um erro ocorreu durante o processo. {ex.Message}");
        }
    }
}