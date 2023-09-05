var brics = new SortedDictionary<int, string>()
{
    {20, "Brasil" },
    {10, "China" },
    {40, "India" },
    {30, "Russia" },
};

//adicionando novo elemnto de chave 70
if (brics.ContainsKey(70))
    Console.WriteLine("Chave ja existe");
else
    brics.Add(70, "Africa do sul");

//ver quantos elementos tem
Console.WriteLine(brics.Count);

//acessar pela chave
Console.WriteLine(brics[20]);

//alterar valor
brics[20] = "Argentina";

Console.WriteLine(brics[20]);

//remover
brics.Remove(10);

//verifica se chave ou valor existe
Console.WriteLine(brics.ContainsKey(30));

Console.WriteLine(brics.ContainsValue("Russia"));
Console.WriteLine(brics.ContainsValue("Chile"));

//obtendo valor via trygetvalue
if(brics.TryGetValue(30, out string? valor))
{
    Console.WriteLine(valor);//coloca o valor da chave
}
else
{
    Console.WriteLine("Chave não existe");
}


//percorer a coleção
foreach (var item in brics)
{
    Console.WriteLine(item);
}

foreach (var item in brics)
{
    Console.WriteLine(item.Key + item.Value);
}


Console.ReadKey();  