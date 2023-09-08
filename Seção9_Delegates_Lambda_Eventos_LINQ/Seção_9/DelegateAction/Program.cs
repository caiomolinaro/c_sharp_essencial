//delegate action<t> = representa um método que não retorna um valor, mas pode receber até
//19 argumentos de entrada. util para representar um método que executa uma ação, sem retornar nenhum valor
//usado com arrays e listas

Console.WriteLine("Digite um numero");
int numero = Convert.ToInt32(Console.ReadLine());

Action<int> dobra = x => Console.WriteLine(x * 2);

dobra(numero);

Console.ReadKey();  
