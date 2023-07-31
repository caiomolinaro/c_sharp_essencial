Console.WriteLine("Instrução if");

//Console.WriteLine("Cliente especial (true/false)?");
//var resposta = Convert.ToBoolean(Console.ReadLine());  

//if (resposta)
//{
//    Console.WriteLine("Desconto de 10%");
//}

Console.WriteLine("Informe o valor de x \t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y \t");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X é maior que y");
}

if (x < y)
{
    Console.WriteLine("X é menor que y");
}

if (x == y)
{
    Console.WriteLine("X é igual que y");
}

Console.ReadKey();