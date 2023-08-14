//var aluno = new
//{
//    Nome = "Maria",
//    Idade = 42
//};

//Console.WriteLine(aluno.GetType().ToString());

//Console.WriteLine($"Nome: {aluno.Nome} // Idade: {aluno.Idade}");

//var aluno = new
//{
//    Id = 1,
//    Nome = "Jairo",
//    Email = "jairo@email.com",
//    Endereco = new { Id = 1, Cidade = "Santos", Pais = "Brasil" }
//};

//Console.WriteLine(aluno.Nome);
//Console.WriteLine(aluno.Endereco.Cidade);

var alunos = new[]{
             new{Id = 1, nome = "Maria", Email = "maria@email.com"},
             new{Id = 2, nome = "João", Email = "joao@email.com"},
             new{Id = 3, nome = "Carlos", Email = "carlos@email.com"},
};

Console.WriteLine(alunos[0].nome);
Console.WriteLine(alunos[2].nome);

Console.ReadKey();
