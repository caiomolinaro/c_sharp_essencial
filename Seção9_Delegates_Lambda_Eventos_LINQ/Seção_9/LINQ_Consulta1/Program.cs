
using LINQ_Consulta1;

//fonte de dados
var listaProdutos = Produto.GetProdutos();

Console.WriteLine("\nProdutos eletronicos\n");
var produtosEletonicos = listaProdutos.Where(p => p.Categoria == "Eletronicos");

foreach (var produtos in produtosEletonicos)
{
    Console.WriteLine($"{produtos.Nome} \t{produtos.Preco:C2}");
}


Console.WriteLine("\nProdutos mais caros com estoque superior a 5");
var produtosCarosComEstoque = listaProdutos.Where(p => p.Preco >= 2000 && p.Estoque > 5);
foreach (var produtos in produtosEletonicos)
{
    Console.WriteLine($"{produtos.Nome} \t{produtos.Preco:C2} \tEstoque: {produtos.Estoque}");
}


//cria uma lista de string com nomes dos produtos 

Console.WriteLine("\nLista dos nomes dos produtos ordenados");

var nomesDosProdutos = listaProdutos.Select(p => p.Nome).OrderBy(nome => nome);
foreach(var produtos in nomesDosProdutos)
    Console.WriteLine(produtos);

//realizando calculos 
Console.WriteLine("\n valor medio dos produtos eletronicos");
string categoria = "Eletronicos";
double mediaPrecoEletronicos = listaProdutos.Where(p => p.Categoria == categoria).Average(p => p.Preco);
Console.WriteLine($"{mediaPrecoEletronicos:C}");

Console.ReadKey();