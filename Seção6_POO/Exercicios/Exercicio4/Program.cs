//Exercicío 4
//Crie um programa que solicite ao usuário os nomes de três pessoas e os armazene em uma
//matriz de objetos do tipo Pessoa.
//Para fazer isso, primeiro crie uma classe Pessoa que tenha uma propriedade Nome do tipo
//string, um construtor que receba o nome como parâmetro e sobrescreva o método
//ToString().
//Finalize o programa lendo as pessoas e executando o método ToString() na tela.

using Exercicio4;

int totalPessoas = 3;
Pessoa[] pessoas = new Pessoa[totalPessoas];

Console.WriteLine("Digite o nome de 3 pessoas");

for (int i = 0; i < totalPessoas; i++)
{
    pessoas[i] = new Pessoa(Console.ReadLine());
}

Console.WriteLine("Exibindo o nome das pessoas");

for (int i = 0; i < totalPessoas; i++)
{
    Console.WriteLine(pessoas[i].ToString());
}

Console.ReadKey();  