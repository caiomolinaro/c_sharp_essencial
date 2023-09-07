//Escreva um programa que crie uma lista de objetos Aluno que contém as propriedades : Nome,
//Idade e Sexo. A seguir defina 5 objetos do tipo Aluno e exiba uma lista de objetos alunos no console.

using Exercicio2;

List <Aluno> listaAlunos = new List <Aluno> ();

listaAlunos.Add (new Aluno ("Caio", 22, "Masculino"));
listaAlunos.Add (new Aluno ("Jessica", 27, "Feminino"));
listaAlunos.Add (new Aluno ("João", 20, "Masculino"));
listaAlunos.Add (new Aluno ("Carlos", 21, "Masculino"));
listaAlunos.Add (new Aluno ("Fernanda", 19, "Feminino"));

foreach(var alunos in listaAlunos)
{
    Console.WriteLine($"Nome: {alunos.Nome}  Idade: {alunos.Idade}  Sexo: {alunos.Sexo}");
}