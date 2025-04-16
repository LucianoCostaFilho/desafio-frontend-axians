namespace DesafioAxians.Models
{
    public class Taxa
    {
        public decimal Valor { get; set; }
        public bool Selecionada { get; set; }

        public string Nuts2 { get; set; } = string.Empty;
        public string Nuts3 { get; set; } = string.Empty;
        public string Concelho { get; set; } = string.Empty;

        public Taxa(string nuts2, string nuts3, string concelho, decimal valor)
        {
            Nuts2 = nuts2;
            Nuts3 = nuts3;
            Concelho = concelho;
            Valor = valor;
            Selecionada = false;
        }
    }
}