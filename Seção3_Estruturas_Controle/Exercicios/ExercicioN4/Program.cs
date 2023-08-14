while(true)
{
    int numero;
    int contador = 1;
    Console.WriteLine("Digite um numero maior que zero, digite 999 para sair");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 999)
        break;
    if(numero > 0)
    {
        Console.WriteLine($"Tabuada do {numero}");
        while(contador < 11)
        {
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            contador++;
        }
    }
    else
    {
        Console.WriteLine("Numero deve ser maior que zero");
    }
}