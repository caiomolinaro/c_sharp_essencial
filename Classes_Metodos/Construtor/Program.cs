Aluno aluno = new Aluno("Caio", 22, "Masculino", "S");

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "null" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

Console.ReadKey();

public class Aluno
{

    public Aluno(string nome)=> Nome = nome;


    public Aluno(string nome, int idade, string sexo, string aprovado):this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;

    }


    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}