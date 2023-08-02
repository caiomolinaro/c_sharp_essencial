//int resultado, numero;

//Console.WriteLine("Digite o numero");
//numero = Convert.ToInt32(Console.ReadLine());

//for(int i = 1; i <= 10; i++)
//{
//    resultado = numero * i;
//    Console.WriteLine(numero + "x" + i + "=" + resultado );
//}

for(int x = 0; x < 5; x++)
{
    for(int y = 0; y < 5; y++)
    {
        Console.WriteLine($"({x}, {y}) ");
    }
}

Console.ReadKey();