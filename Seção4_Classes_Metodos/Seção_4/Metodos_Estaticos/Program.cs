var soma = Calculadora.Somar(10, 10);
var subtrair = Calculadora.Subtrair(10, 10);
var multiplicar = Calculadora.Multiplicar(10, 10);
var dividir = Calculadora.Dividir(10, 10);

Console.WriteLine(soma);
Console.WriteLine(subtrair);
Console.WriteLine(multiplicar);
Console.WriteLine(dividir);

Console.ReadKey();

public class Calculadora
{
    public static int Somar(int x, int y)
    {
        return x + y;
    }

    public static int Subtrair(int x, int y)
    {
        return x - y;
    }

    public static int Multiplicar(int x, int y)
    {
        return x * y;
    }

    public static int Dividir(int x, int y)
    {
        return x / y;
    }


}
