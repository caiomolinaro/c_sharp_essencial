//11- Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números inteiros maior que zero.

int num1, num2;
string operacao;
float resposta;

Console.WriteLine("Digite o primeiro numero");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe a operação (+, -, /, X");
operacao = Console.ReadLine().ToLower();
Console.WriteLine("Digite o seugundo numero");
num2 = Convert.ToInt32(Console.ReadLine());

switch(operacao)
{
    case "+":
        resposta = num1 + num2;
        break;

    case "-":
        resposta = num1 - num2;
        break;

    case "/":
        resposta = num1 / num2;
        break;

    case "x":
        resposta = num1 * num2;
        break;

    default:
        resposta = 0;
        break;
}
Console.WriteLine($"{num1} {operacao} {num2} = {resposta}");
Console.ReadKey();