﻿namespace Exercicio5
{
    public class Dados
    {
        public static List<Produto> GetProdutos()
        {
            List<Produto> Produtos = new()
            {
            new Produto() { Nome = "Clips",  Preco = 3.95m },
            new Produto() { Nome = "Caneta", Preco=5.99m},
            new Produto() { Nome = "Lápis",  Preco = 4.15m },
            new Produto() { Nome = "Estojo",   Preco = 6.99m },
            new Produto() { Nome = "Caderno", Preco=7.55m}
            };
            return Produtos;
        }
    }
}
