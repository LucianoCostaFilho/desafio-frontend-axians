namespace DesafioAxians.Models
{
    public class Taxa
    {
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public bool Selecionada { get; set; }

        public Taxa(string tipo, decimal valor)
        {
            Tipo = tipo;
            Valor = valor;
            Selecionada = false;
        }
    }
}