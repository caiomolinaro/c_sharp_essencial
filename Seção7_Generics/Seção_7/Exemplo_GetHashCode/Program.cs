var pessoa1 = new Pessoa(123456, "Caio");
var pessoa2 = new Pessoa(123456, "Caio");
var pessoa3 = new Pessoa(987654, "Caio");


Console.WriteLine("Comparando os objetos pessoa com gethashcode");
Console.WriteLine("pessoa1 = " + pessoa1.GetHashCode());
Console.WriteLine("pessoa2 = " + pessoa2.GetHashCode());
Console.WriteLine("pessoa3 = " + pessoa3.GetHashCode());

Console.WriteLine("Comparando com equals");
Console.WriteLine(pessoa1.Equals(pessoa2));
Console.WriteLine(pessoa2.Equals(pessoa3));



Console.ReadKey();

public class Pessoa
{
    public Pessoa(int cpf, string? nome)
    {
        CPF = cpf;
        Nome = nome;
    }

    public int CPF { get; set; }
    public string? Nome { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        if( (obj is not Pessoa))
            return false;

        var other = (Pessoa)obj;

        return CPF.Equals(other.CPF);
    }

    public override int GetHashCode()
    {
        return CPF.GetHashCode();
    }
}
