//delegate predicate = delegates pré definidos

//delegate predicate<t> = representa um método que recebe um unico argumento do tipo t 
//e retorna uma valor bool. pode ser usado para testar se um objeto satisfaz uma condição especifica

//são tipos de referencia que encapsulam um método 

Console.WriteLine("Informe um numero inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

Predicate<int> delegatePar = delegate (int x)
{
    return x % 2 == 0;
};

//com expressão lambda:
//Predicate<int> delegatePar = x => x % 2 == 0;

if (delegatePar(numero))
    Console.WriteLine("par");
else
    Console.WriteLine("impar");

Console.ReadKey();
