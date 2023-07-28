Console.WriteLine("Inferencia tipos var \n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

//var limitações

//var salario = null;
//var titulo;
//var salario, imposto, total

//não pode muda o tipo após inicializar
//var num = 10;
//var = "Teste";

var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();

class Teste
{
   public void MeuMetodo()
    {
        Console.WriteLine("Meu metodo");
    }
}