using LINQ_Consulta2;

var listaProdutos = Produto.GetProdutos();

//first localiza o primeiro elemento

var primeiroProduto = listaProdutos.First();
Console.WriteLine(primeiroProduto.Nome);

var primeiroProduto1 = listaProdutos.FirstOrDefault();
Console.WriteLine(primeiroProduto1.Nome);


//last localiza o ultimo elemento

var ultimoProduto = listaProdutos.Last();
Console.WriteLine(ultimoProduto.Nome);

var ultimoProduto1 = listaProdutos.LastOrDefault();
Console.WriteLine(ultimoProduto1.Nome);


//single retorna o unico elemento que atende uma condição

try
{

    var singleProduto = listaProdutos.Single(p => p.Nome == "Cadeira");
    Console.WriteLine(singleProduto.Nome);

    var singleProduto1 = listaProdutos.SingleOrDefault(p => p.Nome == "Cadeira");
    Console.WriteLine(singleProduto1.Nome);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.ReadKey();