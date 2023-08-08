int x = 20;
Console.WriteLine($"Valor do argumento x antes de passar por valor {x}");

Calculo calculo = new();
calculo.Dobrar( x );

Console.WriteLine($"Valor do argumento x depois de passar por valor {x}");

Console.ReadKey();

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2; //y=y*2
        Console.WriteLine($"Valor do parametro y no método dobrar {y}");
    }
}