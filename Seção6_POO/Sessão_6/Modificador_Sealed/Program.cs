Cliente cliente1 = new();
//cliente1.Nome = "Caio";
cliente1.ExibeNome();

Console.ReadKey();

sealed class Pessoa
{
    public string? Nome { get; set; }
    public void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Cliente
{
    public new void ExibeNome()
    {
        //Console.WriteLine($"Nome do cliente: {Nome}");
    }
}



//o modificador sealed impede que outras classes herdam dela
//pode ser usada em classe ou metodo ou propriedade
