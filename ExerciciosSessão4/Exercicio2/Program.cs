Carro chevrolet1 = new ("Sedan", "Chevrolet");
Console.WriteLine(chevrolet1.VelocidadeMaxima(100));
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
    //g- Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não use a palavra-chave this)
    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    //i- Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que
    //vai retornar um double representando a velocidade máxima do carro
    //(Para calcular a velocidade multiplique a potencia por 1.75)
    public double VelocidadeMaxima (int potencia)
    {
        return 1.75 * potencia;
    }

}