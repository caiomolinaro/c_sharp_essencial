//1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :
//Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings
using System;
using System.Net.Mail;
using System.Runtime.Intrinsics.X86;

string nome = "Paulo";
int idade = 17;
double nota = 7.5;
Console.WriteLine($"{nome} tem {idade} anos e nota {nota}");
Console.ReadLine();

//2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.
string nome1 = "Paulo";
int idade1 = 17;
float nota1 = 7.5f;
Console.WriteLine($"{nome1} \ntem {idade1} anos \ne nota {nota1}");
Console.ReadLine();

/* 3- Para qual tipo de dados você pode converter um float implicitamente ?
( ) int
(X) double
( ) long
(X ) decimal */

/* 4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
( ) int para long
(X) double para long
(X) double para float
(X) decimal para float
(X) long para int
(X) double para decimal */

//5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings
char letra1, letra2, letra3;
Console.WriteLine("Digite a primeira letra:");
letra1 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Digite a segunda letra:");
letra2 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Digite a terceira letra:");
letra3 = Convert.ToChar(Console.ReadLine());
Console.WriteLine(letra3 + " " + letra2 + " " + letra1);
Console.WriteLine($"{letra3} {letra2} {letra1}");
Console.ReadLine();

/* 6- Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
(F) long resultado = 1.32;
(V) var nome = “Maria”;
(V) string resultado = 100.ToString();
(V) A sequência de escape \n inclui uma nova linha
(F) float f = 5.45;
(V) decimal valor = (decimal) 10.99f;
(F) var status = null;
(F) object o = 12.45m;
(V) string titulo = true.ToString();
(F) A sequencia \t inclui uma tabulação vertical */

//7- Escreva um programa para receber dois valores via teclado do tipo double e a seguir
//realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo exibindo o resultado:
Console.WriteLine("Digite o primeiro numero");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"A soma de {num1} + {num2} é {num1 + num2}");
Console.WriteLine($"A subtração de {num1} - {num2} é {num1 - num2}");
Console.WriteLine($"A multiplicação de {num1} * {num2} é {num1 * num2}");
Console.WriteLine($"A divisão de {num1} / {num2} é {num1 / num2}");
Console.WriteLine($"O módulo de {num1} % {num2} é {num1 % num2}");
Console.WriteLine($"Exponenciação = {Math.Pow(num1, num2)}");

//8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de a b e c .
//Valores : a = 1 , b = 12 e c = -13

int a = 1, b = 12, c = -13;
double delta, x1, x2;

delta = Math.Pow(b, 2) * 4 * a * c;

x1 = ((-b) + Math.Sqrt(delta)) / 2 * a;
x2 = ((-b) + Math.Sqrt(delta)) / 2 * a;

Console.WriteLine(" x1 = " + x1);
Console.WriteLine(" x2 = " + x2);
Console.ReadKey();



//9- Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
//Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
//inválido’: (use o operador condicional ternário)
Console.WriteLine("Digite o nome:");
string nomeUser = Console.ReadLine();
Console.WriteLine("Digite a senha:");
int senhaUser = Convert.ToInt32(Console.ReadLine());
var loginUser = (nomeUser == "admin" || nomeUser == "maria") && senhaUser == 123 ? "Login feito com suesso" : "Login invalido";
Console.WriteLine(loginUser);

/* 10 - Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis considerando
a nomenclatura usada:
(V) string? nome; é um exemplo de nullable reference type;
(F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
(F) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
(V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
(F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
(F) Para x = 25 e y=5 , a expressão ( y >= x ) && (y <= x); retorna true;
(V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
(F) Para x = 10, o código Console.WriteLine(x+=x); imprime o valor 10;
(F) Para x = 5, a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
(V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
(V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?" */

//11- Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
Console.WriteLine("Digite o primeiro numero inteiro");
int numInt1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero inteiro");
int numInt2 = Convert.ToInt32(Console.ReadLine());
var parImparNum1 = (numInt1 % 2 == 0) ? "Par" : "Impar";
var parImparNum2 = (numInt2 % 2 == 0) ? "Par" : "Impar";
Console.WriteLine($"O {numInt1} é {parImparNum1} e o {numInt2} é {parImparNum2}");
Console.ReadLine();

//12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no console o resultado das seguintes operações : (x ^ 2->x ao quadrado) (pi = 3.1415)
Console.WriteLine("Informe o valor de x: \t");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(-6 + xA * 5);
Console.WriteLine((13 - 2) * xA);
Console.WriteLine((xA + -2) * (20 / xA));
Console.WriteLine((12 + xA) / (xA - 4));
double resultado = 3 * Math.Pow(xA, 2) + xA + 10;
double area = Math.PI * Math.Pow(xA, 2);
Console.WriteLine(resultado);
Console.WriteLine(area);
Console.ReadKey();

//14- Escreva um programa que solicite a temperatura em graus Celsius e converta para
//Kelvin e Farhenheit usando as fórmulas a seguir:
//-Converter para Kelvin => K = C + 273;
//-Converter para Farhenheit => F = (C * 9) / 5 + 32;
Console.WriteLine("Digite o valor em Celsius");
double celsius = Convert.ToDouble(Console.ReadLine());
double kel = celsius + 273;
double fah = (celsius * 9) / 5 + 32;
Console.WriteLine($"O valor em K é {kel} e o valor em F é {fah}");
Console.ReadLine();

