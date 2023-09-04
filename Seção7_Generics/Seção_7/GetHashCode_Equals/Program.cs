string a = "Caio";
string b = "Caio";

int x = 100;
int y = 100;

var pessoa1 = new Pessoa(1, "Caio");
var pessoa2 = new Pessoa(1, "Caio");

Console.WriteLine(a.Equals(b));
Console.WriteLine(x.Equals(y));
Console.WriteLine(pessoa1.Equals(pessoa2));

Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
Console.WriteLine(x.GetHashCode());
Console.WriteLine(y.GetHashCode());

Console.WriteLine(pessoa1.GetHashCode());
Console.WriteLine(pessoa2.GetHashCode());

public class Pessoa
{
    public Pessoa(int id, string? nome)
    {
        Id = id;
        Nome = nome;
    }

    public int Id { get; set; }
    public string? Nome { get; set; }
}