Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);

//e faça duas chamadas ao método usando o
//conceito de argumentos nomeados não informando o ano na primeira chamada e informando o ano na segunda
//chamada.

Console.WriteLine("Sem informar o ano");
chevrolet.ExibirInfo(Modelo: chevrolet.Modelo, Montadora: chevrolet.Montadora, Marca: chevrolet.Marca, Potencia: chevrolet.Potencia);

Console.WriteLine();

Console.WriteLine("Informando o ano");
chevrolet.ExibirInfo(Modelo: chevrolet.Modelo, Montadora: chevrolet.Montadora, Marca: chevrolet.Marca, Potencia: chevrolet.Potencia, Ano: chevrolet.Ano);

Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }

    //Crie um método chamado ExibirInfo que retorna void e que utiliza os parâmetros : Modelo, Montadora,
    //Marca, Potencia e Ano e que exiba as informações destes atributos no console.
    //Para este método defina o parâmetro Ano como opcional 
    public void ExibirInfo(string? Modelo, string? Montadora, string? Marca, int Potencia, int Ano = 2023)
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Montadora);
        Console.WriteLine(Marca);
        Console.WriteLine(Potencia);
        Console.WriteLine(Ano);
    }

}
