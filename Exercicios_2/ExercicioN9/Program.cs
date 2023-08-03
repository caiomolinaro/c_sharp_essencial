//9 - Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado

int numero = 2;

do
{
    int multiplicador = 1;
    do
    {
        Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");
        multiplicador++;
    }
    while (multiplicador <= 10);
    Console.WriteLine("");
    numero++;
}
while (numero <= 6);

Console.ReadKey();