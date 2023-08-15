string[] nomes = { "Ana", "Maria", "Caio", "Paulo", "Carlos" };

Console.WriteLine("Exibindo o array original");

ExibeArray(nomes);

Console.WriteLine();

Console.WriteLine("Invertendo a ordem do array original");
Array.Reverse(nomes);
ExibeArray(nomes);

Console.WriteLine();

Console.WriteLine("Ordenando o array");
Array.Sort(nomes);
ExibeArray(nomes);

Console.WriteLine();

Console.WriteLine("Localiznado um item no array");
Console.WriteLine("Informe um nome");
string? nome = Console.ReadLine();

var indice = Array.BinarySearch(nomes, nome);

if (indice >= 0)
    Console.WriteLine($"O {nome} foi encontrado com o indice: {indice}");
else
    Console.WriteLine($"{nome} não foi encontrado");


Console.ReadKey();

static void ExibeArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
    }
}