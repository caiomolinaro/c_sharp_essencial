
Carro chevrolet = new(1996);
Console.WriteLine($"Ano: {chevrolet.Ano}");

Console.ReadKey();

public class Carro
{
    //Substituir na classe Carro o campo Ano por uma propriedade de mesmo nome e mesmo tipo
    private int ano;
    public int Ano
    {
        get { return ano; }
        set
            //Validar a informação do Ano de forma que se o ano informado for menor que 2000 seja atribuído 2000 e se
//for informado maior que 2022 seja atribuído 2022 ao valor do ano
        {
            if (value < 2000)
                ano = 2000;
            else if (value > 2022)
                ano = 2022;
            else
                ano = value;
        }
    }

    public Carro(int Ano)
    {
        this.Ano = Ano;
    }
}
