//Delegate é um tipo que representa referencias a emetodos com uma lista de parametros e um tipo de retorno especifico

//São usados para implementar eventos, métodos de retorno de chama e para passar métodos como argumentos para outros métodos

//DEFINIR FORA DO METODO MAIN O DELEGATE

using Delegates;

var resultado = Calculadora.Somar(10, 40);


//DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Somar); //metodo de invocar delegate 
//var resultado1 = calc(20, 30);
//Console.WriteLine($"Resultado: {resultado1}");

DelegateCalculadora calc = Calculadora.Somar; //outro metodo de invocar delegate
var resultado2 = calc(20, 30);
Console.WriteLine($"Resultado: {resultado2}");

calc = Calculadora.Dividir; 
var resultado3 = calc(20, 30);
Console.WriteLine($"Resultado: {resultado3}");

calc = Calculadora.Subtrair;
var resultado4 = calc(20, 30);
Console.WriteLine($"Resultado: {resultado4}");

calc = Calculadora.Multiplicar;
var resultado5 = calc(20, 30);
Console.WriteLine($"Resultado: {resultado5}");

//DelegateCalculadora calc3 = (float x, float y) => Calculadora.Somar(x, y); //outro metodo de invocar delegate, agr com expressão lambda
//var resultado3 = calc3(20, 30);
//Console.WriteLine($"Resultado: {resultado3}");



Console.ReadKey();

public delegate float DelegateCalculadora(float x, float y); //criando delegate