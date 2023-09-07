//Escreva um programa que solicite ao usuário a informação da idade e do nome via teclado que deverão ser
//armazenados nas variáveis idade do tipo int e nome do tipo string.
//A seguir realize o tratamento de erro e lançando as exceções considerando as seguintes condições:
//a - Se a idade é negativa, uma exceção ArgumentException é lançada com a mensagem "A idade não pode ser
//negativa."
//b - Se a idade é zero, uma exceção NotImplementedException é lançada com a mensagem "A idade ainda não foi
//definida."
//c- Se o nome é nulo ou vazio, uma exceção NullReferenceException é lançada com a mensagem "O nome não pode
//ser nulo nem vazio"
//Nota: No item c use a expressão string.IsNullOrEmpty(nome)para verificar se o nome é null ou
//vazio.

using System;

string nome = null;
int idade = 0;

try
{
    Console.WriteLine("Digite a idade");
    idade = Convert.ToInt32(Console.ReadLine());

    if (idade < 0 )
    {
        throw new ArgumentException("A idade não pode ser negativa");
    }

    if (idade == 0)
    {
        throw new NotImplementedException("A idade ainda não foi definida");
    }

    Console.WriteLine("Digite o nome:");
    nome = Console.ReadLine();
    if (string.IsNullOrEmpty(nome))
    {
        throw new NullReferenceException("O nome não pode ser nulo nem vazio");
    }

    Console.WriteLine(nome);
    Console.WriteLine(idade);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Erro " + ex);
}
catch (NotImplementedException ex)
{
    Console.WriteLine("Erro " + ex);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Erro " + ex);
}
catch(Exception ex)
{
    Console.WriteLine("Erro " + ex);
}