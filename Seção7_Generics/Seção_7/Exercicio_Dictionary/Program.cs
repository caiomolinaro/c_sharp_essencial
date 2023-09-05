using Exercicio_Dictionary;

//criando a coleção
var alunos = new Dictionary<int, Alunos>()
{
    {1, new Alunos("Maria", 7)},
    {2, new Alunos("Eric", 8)},
    {3, new Alunos("Ana", 9)},
    {4, new Alunos("Alex", 6)},
    {5, new Alunos("Diná", 5)},
};

//acessar e exibir os nomes e as notas

ExibirColecao(alunos);

//localizar e atualizar nota de um aluno

Console.WriteLine();

do
{
    Console.WriteLine("Informe a chave do aluno a ser localizado, 99 sai");
    int codigo = Convert.ToInt32(Console.ReadLine());

    if (codigo == 99)
        break;

    var resultado = alunos.ContainsKey(codigo);
    if (resultado )
    {
        Console.WriteLine("Informe a nota 1 a 10");
        int nota = Convert.ToInt32(Console.ReadLine());
        alunos[codigo].Nota = nota;
    }
    else
    {
        Console.WriteLine("Aluno não encontrado");
    }
}
while (true);
ExibirColecao(alunos);




//remover um aluno da coleção

Console.WriteLine();

Console.WriteLine("Informe a chave do aluno a ser removido");
int code = Convert.ToInt32(Console.ReadLine());
if(alunos.ContainsKey(code))
{
    alunos.Remove(code);
    Console.WriteLine("Aluno removido");
}
else
{
    Console.WriteLine("Aluno não encontado");
}
ExibirColecao(alunos);




//incluir um novo aluno - Vilma - 7

Console.WriteLine();

Console.WriteLine("Digite o nome do aluno");
string novoNome = Console.ReadLine();

Console.WriteLine("Digite a nota");
int novaNota = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o código do aluno");
int novoCodigo = Convert.ToInt32(Console.ReadLine());   

if(!alunos.ContainsKey(novoCodigo))
{
    alunos.Add(novoCodigo, new Alunos(novoNome, novaNota));
    Console.WriteLine("Aluno incluido com sucesso");
}
else
{
    Console.WriteLine("Código de aluno já existe");
}
ExibirColecao(alunos);

//ordenar os alunos por nome

Console.WriteLine();

var alunosOrdenados = alunos.OrderBy(x => x.Value.Nome);
foreach (var item in alunosOrdenados)
{
    Console.WriteLine($"Chave: {item.Key} // Nome: {item.Value.Nome} // Nota: {item.Value.Nota}");
}

//remover todos os dados da coleção

Console.WriteLine();

alunos.Clear();
ExibirColecao(alunos);

Console.WriteLine("Fim do exercicio");

Console.ReadKey();

static void ExibirColecao(Dictionary<int, Alunos> alunos)
{
    foreach (var item in alunos)
    {
        Console.WriteLine($"Chave: {item.Key} // Nome: {item.Value.Nome} // Nota: {item.Value.Nota}");
    }
}