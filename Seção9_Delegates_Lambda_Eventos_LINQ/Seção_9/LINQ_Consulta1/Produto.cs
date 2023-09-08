
namespace LINQ_Consulta1
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public string? Categoria { get; set; }

        public static List<Produto> GetProdutos()
        {
            List<Produto> produtos = new List<Produto>()
        {
            new Produto { Id = 1, Nome = "Camiseta", Preco = 29.99, Estoque = 50, Categoria = "Roupas" },
            new Produto { Id = 2, Nome = "Meia Soc", Preco = 89.99, Estoque = 20, Categoria = "Roupas" },
            new Produto { Id = 3, Nome = "Calça Jeans", Preco = 89.99, Estoque = 20, Categoria = "Roupas" },
            new Produto { Id = 4, Nome = "Tenis Nike", Preco = 199.99, Estoque = 10, Categoria = "Calçados" },
            new Produto { Id = 5, Nome = "Celular NK", Preco = 1499.99, Estoque = 9, Categoria = "Eletronicos" },
            new Produto { Id = 6, Nome = "Notebook", Preco = 4599.99, Estoque = 6, Categoria = "Eletronicos" },
            new Produto { Id = 7, Nome = "Mochila", Preco = 139.99, Estoque = 30, Categoria = "Acessorios" },
            new Produto { Id = 8, Nome = "Relógio", Preco = 399.99, Estoque = 15, Categoria = "Acessorios" },
            new Produto { Id = 9, Nome = "Cadeira", Preco = 799.99, Estoque = 8, Categoria = "Moveis" },
            new Produto { Id = 10, Nome = "Mesa sala", Preco = 2499.99, Estoque = 7, Categoria = "Moveis" },
            new Produto { Id = 11, Nome = "Smart TV", Preco = 3999.99, Estoque = 4, Categoria = "Eletronicos" },
        };
            return produtos;
        }
    }
}
