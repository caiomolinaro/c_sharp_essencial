Aluno aluno1 = new();
Aluno aluno2 = new("Caio");

Console.ReadKey();  

//classe base
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("construtor da classe Pessoa");
    }
    public Pessoa (string nome)
    {
        Console.WriteLine("Construtor da classe pessoa com parametro");
    }
}

//classe derivada
class Aluno : Pessoa
{
    public Aluno() : base() //chamando o construtor sem parametros da classe base
    {
        Console.WriteLine("construtor da classe Aluno");
    }
    public Aluno (string nome) : base(nome) //chamando o construtor com parametros da classe base
    {
        Console.WriteLine("construtor da classe aluno com parametro");
    }
}

//palavra chave base()