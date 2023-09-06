//criando a queue

//Queue<string> diasSemana = new Queue<string> ();
//diasSemana.Enqueue("Segunda");
//diasSemana.Enqueue("Terça");

//int[] array1 = new int[] {1, 2, 3, 4, 5}; //partindo de coleção ja existente
//var numeros = new Queue<int> (array1);

//var impares = new Queue<int>(3);
//impares.Enqueue(5);
//impares.Enqueue(3);
//impares.Enqueue(1);


string[] cursos = { "C#", "Python", "Java", "SQL", "ASP.NET" };
Queue<string> fila1 = new Queue<string>(cursos);

Console.WriteLine(fila1.Count()); //conta elemento

ExibirFila(cursos);

fila1.Enqueue(".NET MAUI"); //inclui elemento

ExibirFila(fila1);


//obtem o primeiro item da fila mas nao remove
var elemento = fila1.Peek();
Console.WriteLine(elemento);


//remove do inicio da fila
fila1.Dequeue();
ExibirFila(fila1);

//verifica se o elemento existe na fila
if(fila1.Contains("C#"))
    Console.WriteLine("c# tem");
else
    Console.WriteLine("c# não tem");


fila1.Clear(); // limpa todos os elementos










Console.ReadKey ();

static void ExibirFila<T>(IEnumerable<T> fila1)
{
    Console.WriteLine();
    foreach (var item in fila1)
    {
        Console.WriteLine(item);
    }
}