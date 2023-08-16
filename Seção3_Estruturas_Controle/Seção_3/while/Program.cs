//var i = 1;
//while (i <= 10)
//{
//    Console.WriteLine(i);
//    i++;
//}

//int numero;
//int contador = 1;

//Console.WriteLine("Digite um numero maior que 0");
//numero = Convert.ToInt32(Console.ReadLine());

//if(numero > 0)
//{
//    Console.WriteLine($"\nTabuada do {numero}");
//    while(contador < 11)
//    {
//        Console.WriteLine($"{numero} x {contador} = {numero*contador}");
//        contador++;
//    }
//}
//else
//{
//    Console.WriteLine("Numero deve ser maior que zero");
//}

//while (true) 
//{
//    Console.WriteLine("Digite um numero inteiro (para sair tecle 999)");
//    int numero = Convert.ToInt32(Console.ReadLine());

//    if (numero == 999)
//    {
//        break;
//    }
//    if (numero%2 == 0)
//    {
//        Console.WriteLine($"{numero} é par");

//    }
//    else {
//        Console.WriteLine($"{numero} é impar");
//    }
//}

int x = 0; 
while (x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.WriteLine($"({x}, {y})");
        y++;
    }
    x++;
    Console.WriteLine();
}


Console.ReadKey();