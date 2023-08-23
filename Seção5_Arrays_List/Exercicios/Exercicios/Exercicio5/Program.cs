//- Dada uma classe Produto contendo duas propriedades : Nome (string) e Preco (decimal). Crie uma lista
//de objetos do tipo Produto usando os seguinte dados:
//Clips, R$ 3,95 - Caneta, R$ 5,99 - - Lápis, R$ 4,15 - Estojo, R$ 6,99 e Caderno, R$ 7,55 
using Exercicio5;

List<Produto> Produtos = Dados.GetProdutos();
ExibirProdutos(Produtos);

//2- Inclua na lista o seguinte produto : Mochila, R$ 22,44 e exiba novamente a lista de produtos
Console.WriteLine("Adicionando um produto Mochila R$22.44");
Produto mochila = new Produto() { Nome = "Mochila", Preco = 22.44m};
Produtos.Add(mochila);
ExibirProdutos(Produtos);

//5- Localize na lista o produto com nome Estojo
Console.WriteLine("Localizando o produto Estojo");
var produto1 = Produtos.Find(n => n.Nome.Equals("Estojo"));
Console.WriteLine($"Produto: {produto1.Nome} - {produto1.Preco}");

//3- Ordene a lista pelo nome do produto e exiba a lista ordenada
Console.WriteLine("Ordenando produtos por nome");
var listaOrdenada = Produtos.OrderBy(n => n.Nome).ToList();
ExibirProdutos(listaOrdenada);

//4- Obtenha e exiba no console os produtos com preço inferior a R$ 5,00 
Console.WriteLine("Localizar e exibir os produtos com preço abaixo de R$5.00");
var produtosAbaixoCinco = Produtos.FindAll(n => n.Preco <= 5.00m);
Console.WriteLine("Os produtos com preço menor que R$5.00");
foreach(var item in produtosAbaixoCinco) 
{
    Console.WriteLine($"{item.Nome}\t{item.Preco}");
}

Console.ReadKey();

//1- Crie um método para exibir a relação de produtos , a soma total dos preços dos produtos, a média do
//preço dos produtos e a quantidade de produtos na lista
static void ExibirProdutos(List<Produto> Produtos)
{
    Console.WriteLine("Relação de produtos");
    Console.WriteLine("\nNome\tPreço");

    var somaPreco = 0.0m;

    foreach (var item in Produtos)
    {
        Console.WriteLine($"{item.Nome}\t{item.Preco}");
        somaPreco += item.Preco;
    }

    var mediaPreco = somaPreco / Produtos.Count();
    Console.WriteLine($"\nMédia dos preços : {Math.Round(mediaPreco, 2)}");
    Console.WriteLine($"\nTotal de Produtos : {Produtos.Count()}");
}