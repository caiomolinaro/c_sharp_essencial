//Escreva um programa onde o usuário é solicitado a informar um valor via teclado e armazenar o valor na
//variável entrada do tipo string onde tem que verificar 3 condições diferentes:
//a - Se a entrada é nula, uma exceção ArgumentNullException é lançada com a mensagem "A entrada não pode ser
//nula." (Verifique a diferença entre ArgumentException e ArgumentNullException)
//b-Se a entrada está vazia, uma exceção ArgumentException é lançada com a mensagem "A entrada não pode estar
//vazia."
//c-Se a entrada passar nas verificações anteriores, a entrada é exibida na tela.
//Realize o tratamento de erro para essas condições usando o bloco try-cath-finally

string digitado = null;
try
{
    Console.WriteLine("Digite algo...");
    digitado = Console.ReadLine();

    if (digitado == null)
    {
        throw new ArgumentNullException("A entrada não pode ser nula");
    }
    else if(string.IsNullOrEmpty(digitado))
    {
        throw new ArgumentException("A entrada não pode estar vazia");
    }
    else
    {
        Console.WriteLine($"Você digitou: {digitado}");
    }
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Erro " + ex.Message);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Erro " + ex.Message);
}

