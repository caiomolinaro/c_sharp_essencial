Dictionary<int, int> dic1 = new Dictionary<int, int>();
var dic2 = new Dictionary<int, int>();
dic2.Add(2, 100);
dic2.Add(4, 400);
dic2.Add(3, 500);

var dic3 = new Dictionary<int, int>()
{
    { 1, 100},
    { 2, 200},
    { 3, 300},
};

try
{
    dic3.Add(3, 333);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

var resultado = dic3.TryAdd(3, 333);
Console.WriteLine("Elemento foi incluido ? " + resultado);

if(!dic3.ContainsKey(7))
{
    dic3.Add(7, 7000);
}

Console.WriteLine(dic3[7]);

if (dic3.ContainsValue(7000))
{
    Console.WriteLine("Existe o valor");
}

if (dic3.ContainsKey(7))
{
    dic3[7] = 777;
}
Console.WriteLine("Valor alterado " + dic3[7]);

//tentando obter elemento com chave inexistente

try
{
    Console.WriteLine(dic3[5]);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

//usando o trygetvalue para a chave 5

if (dic3.TryGetValue(7, out int valor))
{
    Console.WriteLine("Valor para chave 7 = " + valor);
}
else
{
    Console.WriteLine("Chave não encontrada");
}

dic3.Add(6, 4444);
dic3.Add(4, 4444);

foreach (var item in dic3)
{
    Console.WriteLine(item);
}

//ordenando usando o sorteddictionary

var dic3Ordenado = new SortedDictionary<int, int>(dic3);

foreach(var item in dic3Ordenado)
{
    Console.WriteLine(item);
}

//ordenando usando o linq

var dic3OrdenadoLinq = dic3.OrderBy(x => x.Key);

foreach (var item in dic3OrdenadoLinq)
{
    Console.WriteLine(item);
}

Console.ReadKey();  