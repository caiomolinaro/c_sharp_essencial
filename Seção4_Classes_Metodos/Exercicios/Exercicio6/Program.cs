//Acesse o valor do campo ValorIpva e exiba no console. 

Carro.ObterValorIpva();
Console.WriteLine($"Valor do IPVA: {Carro.ValorIpva}%");

Console.ReadKey();

//Crie um campo estático ValorIpva do tipo double que vai definir o valor percentual do IPVA cobrado para
//todos os carros
public class Carro
{
    //Crie um campo estático ValorIpva do tipo double que vai definir o valor percentual do IPVA cobrado para
    //todos os carros
    public static double ValorIpva;

    //Crie um método estático ObterValorIPVA que atribua o valor 4 ao campo ValorIpva
    public static void ObterValorIpva()
    {
        ValorIpva = 4;
    }
}
