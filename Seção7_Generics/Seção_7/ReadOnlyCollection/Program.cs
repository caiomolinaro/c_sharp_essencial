using System.Collections.ObjectModel;
using System.Security.Cryptography;

var planetas = new List<string>()
{
    "Mercurio", "Venus", "Terra", "Marte"
};


//criando a coleção readonlycollection

var listaPlanetas = new ReadOnlyCollection<string>(planetas);

//var novaLista = planetas.AsReadOnly();


//listar os items

foreach (var planet in listaPlanetas)
{
    Console.WriteLine(planet);
}

//quantidade de items

Console.WriteLine(listaPlanetas.Count);

Console.WriteLine(listaPlanetas.Contains("Jupiter") ? "Sim" : "Não");

//obter elemento a partir do indice

Console.WriteLine(listaPlanetas[3]);

//obter o indice de um elemento

Console.WriteLine(listaPlanetas.IndexOf("Terra"));



//inserindo novo elemento na lista original no indice 4
planetas.Insert(4, "Jupiter");

foreach (var planet in planetas)
    Console.WriteLine(planet);



//copiando os elemntos para um array unidimensional

string[] planetasArray = new string[listaPlanetas.Count + 2]; //definindo o tamanho como o elemento do listaplanetas + 2 ou seja 7 é o tamanho
listaPlanetas.CopyTo(planetasArray, 1);

foreach (var planet in planetasArray)
    Console.WriteLine(planet);




Console.ReadKey();  

//coleçoes somente leitura perimite que os dados só sejam acessados, mas não modificados

//se a readonly vem de uma lista existente(lista original) se alguam coisa lá é modificado é modificado no readonly tambem