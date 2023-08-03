//8 - Escreva um programa para calcular o fatorial de um número inteiro.
//O fatorial de um número é representado por : n! => n * (n – 1) *(n – 2) ....2 * 1
//Exemplo: fatorial de 6 é representado por 6! = 6*5*4*3*2*1

int i, f = 1, num;

Console.WriteLine("Informe o número inteiro maior que zero");
num = Convert.ToInt32(Console.ReadLine());

for (i = 1; i <= num; i++)
    f = f * i;

Console.WriteLine($"O fatorial de {num} é {f}");