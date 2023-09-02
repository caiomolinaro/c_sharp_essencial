//Exercicio 2
//Crie um programa para gerenciar um álbum de fotos usando os conceitos da programação
//orientada a objetos
//Para começar, crie uma classe chamada LivroFotos com um atributo protected numPaginas do
//tipo int. Defina também um método público GetNumeroPaginas que retornará o número de
//páginas do álbum de fotos.
//O construtor padrão deverá criar um álbum com 16 páginas a classe deve possuir um
//construtor adicional, com o qual podemos especificar o número de páginas que queremos
//no álbum. Crie também uma classe SuperLivroFotos cujo construtor criará um álbum com
//64 páginas.
//Por fim, execute as seguintes ações:
//-Criar um álbum de fotos padrão e exibir o número de páginas
//- Criar um álbum de fotos com 24 páginas e exibir o número de páginas
//- Criar um álbum de fotos grande e exibir o número de páginas
//Para começar, crie uma classe chamada LivroFotos com um atributo privado numPaginas do
//tipo int. Defina também um método público GetNumeroPaginas que retornará o número de
//páginas do álbum de fotos

using Exercicio2;

LivroFotos album1 = new LivroFotos();
Console.WriteLine("Fazendo o primeiro album");
Console.WriteLine($"{album1.GetNumeroPaginas()} páginas");

LivroFotos album2 = new LivroFotos(24);
Console.WriteLine("Fazendo o segundo album");
Console.WriteLine($"{album2.GetNumeroPaginas()} páginas");

SuperLivroFotos album3 = new SuperLivroFotos();
Console.WriteLine("Fazendo o terceiro album");
Console.WriteLine($"{album3.GetNumeroPaginas()} páginas");



Console.ReadKey();  