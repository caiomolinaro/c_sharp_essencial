var gato = new Gato() { Nome = "gatinho" };
gato.ExibeNome();

var cao = new Cachorro() { Nome = "luke" };
cao.ExibeNome();

Console.ReadKey();

//clase base
class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome() 
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Gato : Animal
{
    public override void ExibeNome()
    {
        Console.WriteLine($"Eu sou um gato e meu nome é {Nome}");
    }
}

class Cachorro : Animal
{
}

//virtual sinaliza que o metodo deve ser reescrito ou extendido
//override reescreve o metodo