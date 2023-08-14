//Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de
//resposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder.
//Não utilize a instrução break

string resposta;
bool condicao = true;

Console.WriteLine("Qual a instrução para sair de um loop ?");
Console.WriteLine("a. quit");
Console.WriteLine("b. continue");
Console.WriteLine("c .break");
Console.WriteLine("d. exit");

while(condicao)
{
    Console.WriteLine("Qual a opção correta? tecle o x para sair");
    resposta = Console.ReadLine().ToLower();
    if (resposta == "c")
    {
        Console.WriteLine("Resposta correta parabéns =D");
        condicao = false;
    }
    else if (resposta == "x")
    {
        Console.WriteLine("Programa encerrado, tchau =|");
        condicao = false;
    }
    else
    {
        Console.WriteLine("Resposta incorreta, Que pena =(");
    }
}
