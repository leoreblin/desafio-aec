namespace DesafioAeC.Automation.Domain.Entities
{
    public class SearchResult
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Professor { get; set; } = string.Empty;
        public string CargaHoraria { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
    }
}
