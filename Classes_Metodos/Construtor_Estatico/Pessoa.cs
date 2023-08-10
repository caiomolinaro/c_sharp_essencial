public class Pessoa
{
    public static int IdadeMinima;

    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Console.WriteLine("Executando o construtor parametrizado");
        Nome = nome;
        Idade = idade;
    }

    public Pessoa()
    { }

    static Pessoa()
    {
        Console.WriteLine("Executando o construtor estático");
        Console.WriteLine("Iniciando IdadeMinima");
        IdadeMinima = 18;

    }
}
