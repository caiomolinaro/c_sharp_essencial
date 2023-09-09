//Utilizando o método OrderBy
//Dado um array de inteiros, escreva um programa em C# que use a biblioteca LINQ para ordenar os valores
//em ordem crescente.

int[] numeros = new int[]
{
    20, 14, 3, 1, 0, 50, 98, 154, 2, 2544, 12, 30, 44
};

var numerosOrdenados = numeros.OrderBy(numeros => numeros);
foreach (var numero in numerosOrdenados)
{
    Console.WriteLine(numero);
}