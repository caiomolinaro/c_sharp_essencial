//delegate func<t,tresult> = recebe de 0 até 16 argumentos do tipo t de entrada e retorna um valor do tipo
//tresult. é util para representar um método que executa uma operação e retorna um resultado

Console.WriteLine("Digite o numero");
double numero = Convert.ToDouble(Console.ReadLine());


Func<double, double > raizQuadrada = Math.Sqrt;

double resultado= raizQuadrada(numero);

Console.WriteLine($"A raiz de {numero} é {resultado}");

Console.ReadKey();

public delegate TResult Func <in T, out TResult> (T arg);