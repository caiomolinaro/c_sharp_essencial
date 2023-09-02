namespace Exercicio3
{
    public class Professor : Pessoa
    {
        public Professor(string? nome) : base(nome)
        {
            Nome = nome;
        }

        public void Explicar()
        {
            Console.WriteLine($"Professor {Nome} está explicando");
        }
    }
}
