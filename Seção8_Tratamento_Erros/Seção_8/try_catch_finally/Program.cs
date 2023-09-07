try
{
    Console.WriteLine("Digite o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = (dividendo / divisor);
    Console.WriteLine($"{dividendo} / {divisor} = {resultado}");

    Console.ReadKey();
}
catch (FormatException)
{
    Console.WriteLine("Informe um numero inteiro");
}
catch(OverflowException)
{
    Console.WriteLine("Informe um numero inteiro entre 1 e 999999");
}
catch(DivideByZeroException)
{
    Console.WriteLine("Não tem como dividir por zero");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




