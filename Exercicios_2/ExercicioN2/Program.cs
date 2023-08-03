int a, b, c;
double d, x1, x2;

Console.WriteLine("Informe o valor de A ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de B ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de C ");
c = Convert.ToInt32(Console.ReadLine());

d = b * b - 4 * a * c;

if(d == 0)
{
    Console.WriteLine("Duas raizes são iguais");
    x1 = -b / (2.0 * a);
    x2 = x1;
    Console.WriteLine($"A primeira raiz é x1={x1}");
    Console.WriteLine($"A segunda raiz é x2={x2}");
}
else if (d > 0)
{
    Console.WriteLine("Ambas raizes são reais e diferentes");
    {
        x1 = (-b + Math.Sqrt(d)) / (2 * a);
        x2 = (-b - Math.Sqrt(d)) / (2 * a);
        Console.WriteLine($"A primeira raiz é x1={x1}");
        Console.WriteLine($"A segunda raiz é x2={x2}");
    }
}
else
    Console.WriteLine("As raizes são imaginarias ou seja sem solução para os números reais");