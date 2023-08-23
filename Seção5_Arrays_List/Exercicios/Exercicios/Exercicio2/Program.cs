//2- Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas
//etapas a seguir

//a-) Solicite via teclado o número de valores do array (deve ser um número inteiro)

Console.WriteLine("Digite o numero de elementos no Array");
int x = Convert.ToInt32(Console.ReadLine());

//b-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
int[] numeros = new int[x];

for (int i = 0; i < x; i++)
{
    Console.Write($"numeros[{i}] = ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

//c-) Solicite ao usuário um valor de um número inteiro a procurar no array
string numero;

Console.WriteLine("Informe o numero que quer localizar, digite fim para encerrar");
do
{
    numero = Console.ReadLine();

    if (numero != "fim")
    {
        int valor = Convert.ToInt32(numero);

        //d-) Exiba se o número informado existe no array de inteiros ou não 
        if (Array.BinarySearch(numeros, valor) >= 0)
        {
            Console.WriteLine($"O numero {numero} está no Array");
        }
        else
        {
            Console.WriteLine($"O numero {numero} não está no Array");
        }
    }
}
//e -) Repita até que o texto ‘fim’ seja inserido via teclado
while (numero != "fim");

Console.ReadKey();  
