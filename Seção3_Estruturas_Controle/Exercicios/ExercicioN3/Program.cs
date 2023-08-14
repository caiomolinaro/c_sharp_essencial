//- Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop
//while, do -while e for.
//usando while

int i = 1, soma = 0;
Console.WriteLine("Os 10 primeiros numeros naturais são");
while (i <= 10)
{
    soma = soma + i;
    Console.WriteLine(i);
    i++;
}
Console.WriteLine($"A soma dos numeros é {soma}");

//usando o do while

int x = 1, somaDoWhile = 0;
Console.WriteLine("Os 10 primeiros numeros naturais são");
do
{
    somaDoWhile = somaDoWhile + x;
    Console.WriteLine(x);
    x++;
}
while (x <= 10);
Console.WriteLine($"A soma dos numeros é {somaDoWhile}");

//usando o for

int b, somaB = 0;
Console.WriteLine("Os 10 primeiros numeros naturais são");
for(b = 1; b <=10; b++)
{
    somaB = somaB + b;
    Console.WriteLine(b);
}
Console.WriteLine($"A soma dos numeros é {somaB}");