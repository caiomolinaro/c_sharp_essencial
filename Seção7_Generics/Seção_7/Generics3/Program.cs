//análise da segurança de tipagem

using System.Collections;

ArrayList lista = new ArrayList()
{
    50,
    "Generics",
    new Aluno()
};

foreach (var obj in lista)
{
    Console.WriteLine(obj);
}

Console.ReadLine();


public class Aluno
{
    public string? Nome { get; set; }
}