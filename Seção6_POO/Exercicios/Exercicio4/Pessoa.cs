namespace Exercicio4
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
            return "Seu nome é " + Nome;
        }

    }
}
