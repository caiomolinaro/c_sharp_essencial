//Escreva um programa seguindo as seguintes orientações:
//Declare um método genérico chamado ReverterEImprimir em uma classe não genérica chamada
//Exemplo.
//O método recebe como parâmetro um array de qualquer tipo.
//A seguir declare três tipos diferentes de array : um array de int , um array de strings e um array de
//double
//Invoque o método duas vezes com cada array.
//Na primeira vez invoque o método com um determinado array, onde ele usa explicitamente o
//parâmetro de tipo.
//Na segunda vez, invoque o método onde o tipo é inferido.

using Exercicio6;

int[] intArray = { 1, 2, 3, 4, 5 };

string[] stringArray = { "Lucas", "Rafael", "Larissa", "João" };

double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };

Console.WriteLine("Array de numeros inteiros");
Exemplo.ReverterEImprimir<int>(intArray);
Exemplo.ReverterEImprimir(intArray);

Console.WriteLine("Array de strings");
Exemplo.ReverterEImprimir<string>(stringArray);
Exemplo.ReverterEImprimir(stringArray);

Console.WriteLine("Array de numeros double");
Exemplo.ReverterEImprimir<double>(doubleArray);
Exemplo.ReverterEImprimir(doubleArray);