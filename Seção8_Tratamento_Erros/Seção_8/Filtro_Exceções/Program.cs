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
catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
{
    Console.WriteLine("Sextou e nao vamos capturar essa exceção");
    //Console.Writeline(ex);
}
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("filtro de excessão com format");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

