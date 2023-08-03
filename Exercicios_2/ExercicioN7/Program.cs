//7- Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*)

int i, j, linhas;

Console.WriteLine("Informe o numero de linhas");
linhas = Convert.ToInt32(Console.ReadLine());

for(i=1; i <= linhas; i++)
{
    for(j=1; j<= i; j++)
        Console.WriteLine("*");
    Console.WriteLine("\n");
}