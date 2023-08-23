//Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
//as seguintes operações: Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora

string[] dados = new string[]
{
    "Maça", "Banana","Laranja","Uva","Manga","Pera","Abacate","Mamão","Pêssego","Amora"
};


//a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach

//foreach:
foreach (string s in dados)
{
    Console.WriteLine($"{s}");
}

Console.WriteLine();

//for:
for (int i = 0; i < dados.Length; i++)
{
    Console.WriteLine($"{i} {dados[i]}");
}

Console.WriteLine();

//b- Exiba os nomes da segunda e da penúltima fruta no console
Console.WriteLine(dados[1]);
Console.WriteLine(dados[8]);

Console.WriteLine();

//c- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
dados[2] = "Kiwi";
dados[9] = "Caqui";

ExibirArray(dados);

Console.WriteLine();

//d- Ordene a coleção de frutas na ordem ascendente
Array.Sort(dados);
ExibirArray(dados);

Console.WriteLine();

//e- Exiba no console a coleção de nomes de frutas na ordem inversa
Array.Reverse(dados);
ExibirArray(dados);

Console.ReadKey();

static void ExibirArray(string[] dados)
{
    foreach (string s in dados)
    {
        Console.WriteLine(s);
    }
}