Aluno aluno = new();
aluno.Nome = "Caio";
aluno.Curso = "ADS";
Console.WriteLine(aluno.Saudacao());

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set;}
    public string Saudacao() => $"Oi eu sou o {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set;}
    public new string Saudacao() => $"Oi eu sou o {Nome} do curso de {Curso}";
}