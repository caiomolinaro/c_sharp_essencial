int[] valores = { 1, 2, 3, 4, };

var res1 = Calular.Soma(valores);
Console.WriteLine("Resultado:");
Console.WriteLine(res1);

Console.WriteLine();

var res2 = Calular.Soma(new int [] { 1, 2, 3, 4, 5, 6 });
Console.WriteLine("Resultado:");
Console.WriteLine(res2);

Console.WriteLine();

//modificador params deixa eu colocar a lista assim:
var res3 = Calular.Soma(1, 2, 3, 4, 5, 6, 7, 8, 9 );
Console.WriteLine("Resultado:");
Console.WriteLine(res3);

Console.ReadKey();

public class Calular
{
    public static int Soma(params int[] numeros)
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total += numero;
            Console.WriteLine($"Valores somados: {numero}");
        }
        return total;

    }
}

//sintaxe params:
//NomeDoMetodo(params tipo[] nomeDavariavel){}