Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);


Console.WriteLine($"Modelo: {chevrolet.Modelo}, Montadora: {chevrolet.Montadora}, Marca: {chevrolet.Marca}, Ano: {chevrolet.Ano}, Potencia: {chevrolet.Potencia}");

//Faça a chamada ao método exibindo os valores da nova potencia e da nova velocidade

double novaPotencia = chevrolet.AumentarPotenciaVelocidade(chevrolet.Potencia, out double velocidade);
Console.WriteLine($"Nova potencia: {novaPotencia}");

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

    //Crie um método AumentarPotenciaVelocidade que recebe o parâmetro int potencia e retorna um int
    //como valor da nova potência.Neste método use parâmetro out e passe a variável velocidade e que vai
    //retornar a nova velocidade como um double
    //(incremente a potência de 7 e calcule a nova velocidade multiplicando a potência por 1.75)

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }

}
