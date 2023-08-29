Funcionario funci = new();
funci.Nome = "Caio";
funci.Email = "caio@gmail.com";
funci.Empresa = "Google";
funci.Salario = 5000;

Console.WriteLine("Funcionario");
Console.WriteLine(funci.Empresa);
Console.WriteLine(funci.Salario);
funci.Identificar();

Console.WriteLine();

Aluno aluno = new();
aluno.Nome = "Caio";
aluno.Email = "caio@gmail.com";
aluno.Curso = "ADS";
aluno.Nota = 10;

Console.WriteLine("Aluno");
Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Nota);
aluno.Identificar();



Console.ReadLine();

Console.ReadKey();

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

public class Funcionario : Pessoa   
{
    public string? Empresa { get; set; }
    public int Salario { get; set; }

}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}