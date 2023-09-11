//ValueTask - Fornece um resultado esperado de uma operação asssincrona
//ValueTask<T> - Fornece um tipo de valor que encapsula um Task<T> e um T

await MetodoSemRetornoAsync();

var resultado = await MetodoRetornaValorAsync(20);
Console.WriteLine(resultado);

Console.ReadKey();

static async ValueTask MetodoSemRetornoAsync()
{
    Console.WriteLine("Metodo que não retorna valor");
    await Task.Delay(2000);
}
static async ValueTask<int> MetodoRetornaValorAsync(int valor)
{
    Console.WriteLine("Metodo que retorna valor");
    await Task.Delay(2000);
    return valor * 2;
}