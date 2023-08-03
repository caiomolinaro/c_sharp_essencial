//1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior

Console.WriteLine("Digite o primeiro numero");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro numero");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    if(num1 > num3)
    
        Console.WriteLine($"O primeiro numero {num1} é o maior");
    else 
        Console.WriteLine($"O terceiro numero {num3} é o maior");
}
else if(num2 > num3)
    Console.WriteLine($"O segundo numero {num3} é o maior");
else
    Console.WriteLine($"O terceiro numero {num3} é o maior");

Console.ReadKey();