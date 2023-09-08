//LINQ - Language-Integrated Query é um conjunto de tecnologias baseadas na integração de recursos de consulta diretamento no c#

//1-definir a fonte de dados // 2-definir a consulta linq // 3-executar a consulta


//definindo a fonte de dados

List<string> nomes = new List<string>()
{
    "Ana", "Maria", "Pedro", "Lair", "Hugo"
};

//definindo a consulta 

//usando a sintaxe de consulta
var resultado = from m in nomes
                where m.Contains('o')
                select m;


//usando a sintaxe de metodos
var resultado1 = nomes.Where(m => m.Contains('a'));

//executando a consulta

exibirResultado(resultado);
Console.WriteLine();

exibirResultado(resultado1);

static void exibirResultado(IEnumerable<string> resultado)
{
    foreach (var item in resultado)
        Console.WriteLine(item);
}