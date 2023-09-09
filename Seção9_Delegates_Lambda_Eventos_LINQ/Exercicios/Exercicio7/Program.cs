//Utilizando o método Where
//Dado um array de strings, escreva um programa em C# que use a biblioteca LINQ para obter somente as
//strings que contenham a letra 'a'.

string[] nomes = new string[]
{
    "Caio", "Maria", "Marta", "Erick", "Vitor", "Andreia", "Cleiton"
};

var nomesComA = nomes.Where(m => m.Contains('a'));
foreach (var nome in nomesComA)
{
    Console.WriteLine(nome);
}