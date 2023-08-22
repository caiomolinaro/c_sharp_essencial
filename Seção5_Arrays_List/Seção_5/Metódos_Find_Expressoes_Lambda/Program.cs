List<string> frutas = new()
{
"Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

var fruta1 = frutas.Find(i => i.Contains('n'));

var fruta2 = frutas.FindIndex(i => i.Contains('n'));

var fruta3 = frutas.FindLastIndex(i => i.Contains('n'));

var fruta4 = frutas.FindLast(i => i.Contains('n'));

var fruta5 = frutas.FindAll(i => i.Contains('n'));

foreach (var item in fruta5)
{
    Console.WriteLine("Metódo FindAll");
    Console.WriteLine(item);
}

Console.WriteLine("Metódo Find");
Console.WriteLine(fruta1);

Console.WriteLine("Metódo FindIndex");
Console.WriteLine(fruta2);

Console.WriteLine("Metódo FindLastIndex");
Console.WriteLine(fruta3);

Console.WriteLine("Metódo FindLast");
Console.WriteLine(fruta4);


Console.ReadKey();

