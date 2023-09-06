var numeros = new SortedSet<int> { 1, 5, 3, 4, 2 };

exibirColecao(numeros);

var frutas = new SortedSet<string> { "uva", "banana", "pera", "kiwi" };

exibirColecao(frutas);


Console.ReadKey();

static void exibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
    {
        Console.WriteLine(item);
    }
}