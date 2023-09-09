//Utilizando o método FirstOrDefault
//Dado um array de inteiros, escreva um programa em C# que use a biblioteca LINQ para obter o primeiro
//número par do array.

int[] numeros = new int[]
{
    15, 14, 3, 1, 0, 50, 98, 154, 2, 2544, 12, 30, 44
};

int resultado = numeros.FirstOrDefault(n => n % 2 == 0);
Console.WriteLine(resultado);