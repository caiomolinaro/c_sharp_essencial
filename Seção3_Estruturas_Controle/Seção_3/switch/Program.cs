Console.WriteLine("switch");

//int compra = 600;
//Console.WriteLine("Valor da compra: R$600,00");
//Console.WriteLine("Informe o numero de parcelar (1 a 3)");
//var numeroParcelas = Convert.ToInt32(Console.ReadLine());

//switch(numeroParcelas)
//{
//    case 1:
//        Console.WriteLine($"Prestação R${compra/numeroParcelas}");
//        break;
//    case 2:
//        Console.WriteLine($"Prestação R${compra / numeroParcelas}");
//        break;
//    case 3:
//        Console.WriteLine($"Prestação R${compra / numeroParcelas}");
//        break;
//        default: 
//        Console.WriteLine("Valor invalido, informe 1,2 ou 3");
//        break;
//}

//Console.WriteLine("Informe o numero inteiro");
//var numero = Convert.ToInt32(Console.ReadLine());

//switch(numero % 2)
//{
//    case 0:
//        Console.WriteLine($"{numero} é par");
//        break;
//    case 1:
//        Console.WriteLine($"{numero} é impar");
//        break;
//}

Console.WriteLine("Informe o nome do mês");
var mes = Console.ReadLine().ToLower();

switch(mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}

Console.ReadKey();
