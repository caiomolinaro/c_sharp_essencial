using LINQ_Consulta3;

var listaProdutos = Produto.GetProdutos();

//agrupamento por categoria

var produtosPorCategoria = listaProdutos.GroupBy(p => p.Categoria); 
foreach(var grupo in produtosPorCategoria)
{
    Console.WriteLine(grupo.Key + ":"  + grupo.Count());

    foreach(var produto in grupo)
    {
        Console.WriteLine(produto.Nome);
    }
}