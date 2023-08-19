List<string> nomes = new()
{
    "Caio","Beatriz","Douglas","Anderson"
};

foreach (string name in nomes)
{
    Console.WriteLine(name);
}

Console.WriteLine();

nomes.Sort();

foreach (string name in nomes)
{
    Console.WriteLine(name);
}




Console.ReadKey();

//declarações da List<T>
//<T> = T é o tipo da lista

//List<string> lista;
//lista = new List<string>();

//List<int> lista1 = new List<int>();

//var lista2 = new List<float>();

//List<double> lista3 = new();


