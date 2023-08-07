//1 - Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e
//potencia com os tipos de dados string, string, string, int e int.
//Crie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”

//a- Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet , Onix, 2016, 110


//Carro chevrolet = new();
//chevrolet.Modelo = "Sedan";
//chevrolet.Montadora = "Chevrolet";
//chevrolet.Marca = "Onix";
//chevrolet.Ano = 2016;
//chevrolet.Potencia = 110;


//b- Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120


//Carro ford = new();
//ford.Modelo = "SUV";
//ford.Montadora = "Ford";
//ford.Marca = "EcoSport";
//ford.Ano = 2018;
//ford.Potencia = 120;

//c - Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar
//para cada objeto

//f- Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor criado e invoque o
//método Acelerar passando o valor do argumento para o parâmetro no método Acelerar

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);


Console.WriteLine($"Modelo: {chevrolet.Modelo}, Montadora: {chevrolet.Montadora}, Marca: {chevrolet.Marca}, Ano: {chevrolet.Ano}, Potencia: {chevrolet.Potencia}");
chevrolet.Acelerar(chevrolet.Marca);

Carro ford = new("SUV", "Ford", "Ecosport", 2018, 120);


Console.WriteLine($"Modelo: {ford.Modelo}, Montadora: {ford.Montadora}, Marca: {ford.Marca}, Ano: {ford.Ano}, Potencia: {ford.Potencia}");
ford.Acelerar(ford.Marca);

Console.ReadKey();

//e- Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos :
//modelo, montadora, marco, ano e potencia (use a palavra this para identificar a instância da classe)
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

    public void Acelerar(string? marca)
    {
        //d- Altere o método Acelerar para receber um parâmetro do tipo string chamado marca e a seguir altere a
        //mensagem para exibir o texto “Acelerando o meu { marca}“ , seguido da marca do carro.

        // Console.WriteLine("Acelerando");
        Console.WriteLine($"Acelerando o meu {marca}");
    }

}