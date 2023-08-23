//Random random = new Random();


//byte[] randBytes = new byte[10];
//Random random = new Random();
//random.NextBytes(randBytes);

////Console.WriteLine(random.Next());
////Console.WriteLine(random.Next(20));
////Console.WriteLine(random.Next(10,20));
////Console.WriteLine(random.NextDouble());

//for (int i = 0; i < 6; i++) 
//{
//    Console.WriteLine(randBytes[i]);
//}


Console.WriteLine("Sorteio da loteria");

Random random = new Random();
int[] numerosSorteados = new int[6];

for (int i = 0; i < 6; i++)
{
    int numerosAleatorio;
    do
    {
        numerosAleatorio = random.Next(1, 61);
    }
    while (numerosSorteados.Contains(numerosAleatorio));

    numerosSorteados[i] = numerosAleatorio;
}

Array.Sort(numerosSorteados);

Console.WriteLine("\nNumeros sorteados\n");
Console.WriteLine(string.Join("-", numerosSorteados));

Console.ReadKey();