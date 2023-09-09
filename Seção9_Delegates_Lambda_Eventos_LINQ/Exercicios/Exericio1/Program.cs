//Implemente um programa que use delegates para somar dois números inteiros. O programa deve seguir
//as seguintes especificações:
// a - Defina um delegate chamado OperacaoMatematica que recebe dois inteiros como parâmetros e retorna
//um inteiro.
// b-Defina um método que implementam a operação de soma: que recebe os dois inteiros como parâmetros
// c-Crie um objeto delegate do tipo OperacaoMatematica e atribua a ele ao método definido.
// d-Chame o delegate passando os parâmetros necessários e exiba o resultado da operação na tela.

using Exericio1;

OperacaoMatematica delegateSoma = (int x, int y) => Somar.somarNumero(x, y);
var resultado = delegateSoma(20, 20);
Console.WriteLine(resultado);



Console.ReadKey();

public  delegate int OperacaoMatematica(int x, int y);