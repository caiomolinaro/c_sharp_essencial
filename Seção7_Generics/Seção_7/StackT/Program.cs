//criando coleção stack

//Stack<int> numeros = new Stack<int>();
//numeros.Push(1);
//numeros.Push(2);
//numeros.Push(3);
//numeros.Push(4);

//int[] array1 = new int[] { 1, 2, 3, 4, };
//Stack<int> pilha1 = new Stack<int>(array1);

//var impares = new Stack<int>(3);
//impares.Push(1);
//impares.Push(3);
//impares.Push(5);


Stack <int> numeros = new Stack<int> ();
numeros.Push (10);
numeros.Push (20);
numeros.Push (30);
numeros.Push (10);


//exibir a quantidade de elementos
Console.WriteLine(numeros.Count);
ExibirPilha(numeros);


//retorna sem remover elementos
Console.WriteLine();
Console.WriteLine(numeros.Peek());

//remove e retorna
Console.WriteLine();
Console.WriteLine(numeros.Pop());

ExibirPilha(numeros);
Console.WriteLine(numeros.Count);

//contains

if(numeros.Contains (20))
    Console.WriteLine("o 20 está na pilha");


//copiar usando um toarray

var copia = new Stack<int>(numeros.ToArray ());
ExibirPilha(copia);

//remove os items
numeros.Clear();


Console.ReadKey();

static void ExibirPilha<T>(IEnumerable<T> pilha)
{
    Console.WriteLine();
    foreach (var i in pilha)
    {
        Console.WriteLine(i);
    }
}