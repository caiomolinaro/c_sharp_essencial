using System.Drawing;
using System.Runtime.ConstrainedExecution;
using static Exercicio9.CarroEnum;

//Defina um menu de opções exibindo o nome da Cor e o seu valor

Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");
Console.WriteLine("\nSelecione a Cor do carro");

//- Receba a seleção do usuário em uma variável do tipo int cor que vai ser usada para atribuir ao campo Cor

int cor = Convert.ToInt32(Console.ReadLine());

Carro carro = new(cor);
carro.ExibirInfo();

Carro chevrolet = new(cor);
public class Carro
{
    public int Cor;

    public Carro(int cor)
    {
   
        Cor = cor;
    }
    //Altere o método ExibirInfo() incluindo o parâmetro cor do tipo int como parâmetro opcional e exiba o nome da
    //cor a partir do valor da Cor recebida

    public void ExibirInfo(int cor = 1)
    {
 
        Console.WriteLine((Cores)Cor);
    }
}