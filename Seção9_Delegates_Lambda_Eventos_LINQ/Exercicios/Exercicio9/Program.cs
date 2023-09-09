//Utilizando o método GroupBy
//Dado um array de strings, escreva um programa em C# que use a biblioteca LINQ para agrupar as strings por
//tamanho

string[] palavras = { "banana", "abacaxi", "uva","Kiwi", "laranja", "abacate",
"maça", "pera" };

var resultado = palavras.GroupBy(p => p.Length);
foreach(var palavra in resultado)
{
    Console.WriteLine("\nPalavras com tamanho " + palavra.Key + ":");
    foreach (var item in palavra)
    {
        Console.WriteLine(item);
    }
}

