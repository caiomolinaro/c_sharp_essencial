
Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());


try
{
    int z = x / y;
    Console.WriteLine($"{x} / {y} = {z}");
}
catch (Exception ex)
{
    Console.WriteLine("Não da pra dividir por zero");
    Console.WriteLine($"Erro: {ex.Message}");
    Console.WriteLine($"Detalhes: {ex?.StackTrace?.ToString()}");
}
finally
{
    Console.WriteLine("Finalizando =D...");
}

Console.ReadKey();