namespace DesafioAxians.Models
{
    public class Opcao
    {
        public string? ContarSelecionado { get; set; } = "";
        public List<Taxa>? Taxas { get; set; }
        public bool TaxaLocalizacao { get; set; }
        public string? TipoTaxa { get; set; } = "";
    }
}