Calculadora calc = new();

Console.WriteLine(calc.Somar(10,10));
Console.WriteLine(calc.Subtrair(10, 10));
Console.WriteLine(calc.Multiplicar(10, 10));
Console.WriteLine(calc.Dividir(10, 10));


Console.ReadKey();

public class Calculadora
{
    public int Somar(int x, int y)
    {
        return x + y;
    }

    public int Subtrair(int x, int y)
    {
        return x - y;
    }

    public int Multiplicar(int x, int y)
    {
        return x * y;
    }

    public int Dividir(int x, int y)
    {
        return x / y;
    }


}


