//4- Crie um programa C# que usa uma ArrayList para armazenar uma lista de objetos pessoas. 

using Exercicio4;
using System.Collections;

ArrayList lista = new ArrayList();


//b -) A seguir crie uma ArrayList e solicite a informação dos nomes e idades de 3 pessoas via teclado
//armazenando as informações na ArrayList. 

int total = 3;
for (int i = 0; i < total; i++)
{
    Console.WriteLine("Nome: ");
    string? nome = Console.ReadLine();
    Console.WriteLine("Idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    lista.Add(new Pessoa()
    {
        Nome = nome,
        Idade = idade,
    });

}

Console.WriteLine();

//c-) A seguir exiba no console a lista das pessoas com nome e idade
ListaPessoas(lista);

Console.WriteLine();

//d-) Inclua mais dois objetos Pessoa na lista e exiba a nova lista de pessoas
Console.WriteLine("Colocando mais duas pessoas");

Pessoa jaime = new Pessoa() { Nome = "Jaime", Idade = 20 };
Pessoa tania = new Pessoa() { Nome = "Tânia", Idade = 18 };

lista.Add(jaime);
lista.Add(tania);

ListaPessoas(lista);

Console.WriteLine();

//e-) Remova o último elemento da coleção e exiba a lista completa
//Ao incluir os objetos pessoa use os dados : Jaime,20 - Tânia,18
Console.WriteLine("Remover a ultima pessoa");

lista.RemoveAt(lista.Count - 1);
ListaPessoas(lista);

Console.ReadLine();

static void ListaPessoas(ArrayList lista)
{
    Console.WriteLine("Lista atual:");
    foreach (Pessoa pessoa in lista)
    {
        Console.WriteLine(pessoa.Exibir());
    }
}