//EXERCICIOS FASE 1

// 1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
int idade = 35;
Console.WriteLine(idade);
Console.ReadKey();

// 2- Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine(nome);
Console.ReadKey();

// 3- Crie uma variável chamada altura e atribua a ela o valor 3.45.
double altura = 3.45;
Console.WriteLine(altura);
Console.ReadKey();

// 4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine(data);
Console.ReadKey();

// 5- Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;
const int ano = 12;
Console.WriteLine(ano);
Console.ReadKey();

// 6- Declare uma variável nota do tipo double como sendo do tipo Nullabletype e atribua o valor 7.80 e exiba o seu valor.
double? nota = 7.80;
Console.WriteLine(nota);
Console.ReadKey();

// 7- Quais as diferenças entre os tipos por valor e os tipos por referência ?
/* Tipos por valor = Armazenam os dados direto onde cada variável tem a cópia dos dados e são armazenados na memória Stack
   Tipos por referência = Não armazenam os dadsos diretamente e cada var tem uma referência ao local da memória onde estão os dados. São armazenados na memória Heap */

/* 8- Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
(int) x = 10;
(double) numero = 7.99;
(char) letra = 'C';
(float) temperatura = 27.4f;
(bool) ativo = false;
(string) nome = "Manoel";
(decimal) salario = 950.99m;
(datetime) hoje = DateTime.No */

/* 9- Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por
referência (R) :
(V) int n = 1;
(R) string titulo = "A vida";
(V) float f = 12.45f;
(V) double d = 5.45;
(V) decimal valor = 10.99m;
(V) char sexo = ‘M’;
(R) object o = null; */

/* 10- O que é um nullable type e qual a sua utilidade ?
É um recurso do que C# que nos permite atribuir um valor null a um tipo de dado que não aceita por padrão os valores null, uma utilidade é em banco de dados */

/* 11- O que é Camel Case ? Dê um exemplo de sua aplicação. 
 É uma convenção de nomeclatura que inicia com letra minuscula na primeira palavra e com maiuscula na seguna palavra, 
exemplo: camelCase, muito utilizado para declarar variaveis */

/* 12- O que é Pascal Case ? Dê um exemplo de sua aplicação. 
 É uma convenção de nomeclatura que inicia com letra maiuscula na primeira palavra e com maiuscula na seguna palavra, exemplo: 
PascalCase, muito utilizado para nome de classes */

/* 13- Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y.
(Use o operador aritmético + para realizar a operação de soma) */
int x = 77;
int y = 66;
Console.WriteLine($"A soma é {x+y}");
Console.ReadKey();

/* 14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e
string
bool = false
char = \'0'
int = 0
double = 0
float = 0
decimal = 0
string = null
 */

/* 15- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis
considerando a nomenclatura usada:
(F) double 1valor = 12.45;
(F) string #nome = "Pedro";
(V) float _temperatura = 12.45f;
(F) double int = 5;
(F) decimal renda extra = 91.45m;
(F) bool status$conta = false;
(V) string titulo3 = “Tópico 1”;
(V) float salario_mensal = 1999.55f;
(V) int percentualValorDesconto = 5;
(V) const bool MENSALIDADE_EM_DIA = true; */