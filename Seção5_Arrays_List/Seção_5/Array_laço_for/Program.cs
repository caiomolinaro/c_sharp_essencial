﻿int[] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento do indice {i} : {numeros[i]}");
}

string[] nomes = new string[5] { "Ana", "Maria", "Caio", "Paulo", "Carlos" };

Console.WriteLine();

for (int i = 0;i < nomes.Length; i++)
{
    Console.WriteLine($"Elemento do indice {i} : {nomes[i]}");

}

Console.ReadKey();