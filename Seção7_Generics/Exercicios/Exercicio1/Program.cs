//Escreva um programa para adicionar dois números inteiros usando o conceito de Generics.

using Exercicio1;

Somar<int> somarNumeros = new Somar<int>();

Console.WriteLine("Digite o primeiro numero");
var n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
var n2 = Convert.ToInt32(Console.ReadLine());

var result = somarNumeros.SomaNumeros(n1, n2);

Console.WriteLine($"Resultado: {result} ");

Console.ReadKey();