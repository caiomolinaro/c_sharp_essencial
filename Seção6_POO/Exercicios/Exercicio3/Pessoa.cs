namespace Exercicio3
{
    public class Pessoa
    {
        public string? Nome { get; set; }

        public Pessoa(string? nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return "Olá eu me chamo " + Nome;
        }

    }
}
