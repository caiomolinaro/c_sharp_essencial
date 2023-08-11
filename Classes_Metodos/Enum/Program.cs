Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}");
Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}");
Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}");
Console.WriteLine($"{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}");


Console.WriteLine("\nSelcione a categoria teclando o seu valor");
int valor = Convert.ToInt32(Console.ReadLine());

var nomeMembroEnum = (Categorias)valor;
Console.WriteLine($"\nVocê selecionou a categoria : {nomeMembroEnum.ToString()}");



//Console.WriteLine(DiasDaSemana.Domingo);
//Console.WriteLine(DiasDaSemana.Terça);

//int dia1 = (int)DiasDaSemana.Domingo;
//int dia2 = (int)DiasDaSemana.Terça;

//Console.WriteLine($"{DiasDaSemana.Domingo} vale : {dia1}");
//Console.WriteLine($"{DiasDaSemana.Terça} vale : {dia2}");

Console.ReadKey();

enum Categorias
{
    Moda,
    Automotivo,
    Artes,
    Bebidas,
    Livros,
    Brinquedos
}


enum DiasDaSemana
{
    Segunda = 10,
    Terça = 12,
    Quarta = 15,
    Quinta = 17,
    Sexta = 19,
    Sábado = 21,
    Domingo = 22
}

