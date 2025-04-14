namespace DesafioAxians.Models
{
    public class Taxa
    {
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public bool Selecionada { get; set; }

        public string Nuts2 { get; set; } = string.Empty;
        public string Nuts3 { get; set; } = string.Empty;
        public string Concelho { get; set; } = string.Empty;

        public Taxa(string tipo, decimal valor)
        {
            Tipo = tipo;
            Valor = valor;
            Selecionada = false;
        }
    }
}