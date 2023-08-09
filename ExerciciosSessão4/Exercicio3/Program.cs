Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);


Console.WriteLine($"Modelo: {chevrolet.Modelo}, Montadora: {chevrolet.Montadora}, Marca: {chevrolet.Marca}, Ano: {chevrolet.Ano}, Potencia: {chevrolet.Potencia}");
chevrolet.Acelerar(chevrolet.Marca);

//Invocar o método criado e passar o valor do argumento por valor e exibir os valores. 

var novaPotenciaChevrolet = chevrolet.AumentarPotencia(chevrolet.Potencia);
Console.WriteLine($"Nova potencia do chevrolet: {novaPotenciaChevrolet}");


//Invocar o método e passar o valor do argumento por referência e exibir os valores. 
var potenciaRefChevrolet = chevrolet.AumentarPotencia(ref chevrolet.Potencia);
Console.WriteLine($"Aumento por referencia: {potenciaRefChevrolet}");

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

    public void Acelerar(string? marca)
    {
        //d- Altere o método Acelerar para receber um parâmetro do tipo string chamado marca e a seguir altere a
        //mensagem para exibir o texto “Acelerando o meu { marca}“ , seguido da marca do carro.

        // Console.WriteLine("Acelerando");
        Console.WriteLine($"Acelerando o meu {marca}");
    }

    //Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado
    //potencia e retorna um int representando o aumento de potencia.
    //(para aumentar a potência incremente 3 ao parâmetro recebido)
    public int AumentarPotencia(int potencia)
    {
        potencia += 3;
        return potencia;
    }

    //Crie uma sobrecarga para o método AumentarPotencia que recebe um parâmetro do tipo int por referência
    //chamado potencia e retorna um int representando o aumento de potencia.
    //(para aumentar a potência incremente 5 ao parâmetro recebido)
    public int AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return potencia;
    }



}
