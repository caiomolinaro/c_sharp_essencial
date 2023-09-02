//Exercício 5
//Usando os conceitos de polimorfismo escreva um programa para calcular a área do
//Quadrado, Triângulo e do Circulo
//Fórmulas das áreas
//- Quadrado -> A = lado * lado
//- Triângulo -> A = (base * altura)/ 2
//- Circulo->A = Pi * raio * raio ou A = π.r²

using Exercicio5;

Forma circulo = new Circulo(3.5);
Console.WriteLine($"A area do circulo de raio 3.5 = {circulo.Area()}");

Console.WriteLine();

Forma quadrado = new Quadrado(5.5);
Console.WriteLine("Área do quadrado = {0}", quadrado.Area());

Console.WriteLine();

Forma triangulo = new Triangulo(3.0, 5.0);
Console.WriteLine("Área do triângulo = {0}", triangulo.Area());
