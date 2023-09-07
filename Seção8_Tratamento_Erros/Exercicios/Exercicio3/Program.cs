//-Dado um array de inteiros expresso da seguinte forma
//int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };
//Exiba na janela do console os numeros do array e solicite via teclado ao usuário para informar o valor de um índice
//do array para obter o seu respectivo valor.
//Realize o tratamento de exceções filtrando as exceções IndexOutOfRangeException e ArgumentNullException

int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };
Console.WriteLine("Numeros no array");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"{i} - {numeros[i]}" );
}

try
{
    Console.WriteLine("Digite um indice para obter um numero");
    int indice = Convert.ToInt32(Console.ReadLine());

    int valorIndice = numeros[indice];
    Console.WriteLine($"{indice} - {valorIndice}");

}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Fora do range");
    Console.WriteLine(ex.Message);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Não pode ser nulo");
    Console.WriteLine(ex.Message);
}