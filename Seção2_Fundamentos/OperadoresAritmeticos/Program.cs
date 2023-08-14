Console.WriteLine("Operadores aritmeticos \n");

Console.WriteLine("Informe o valor de x");

int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");

int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n Raiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"\n Potencia de x elevado a y = {Math.Pow(x,y)}");
Console.WriteLine($"\n Valor minimo entre x e y = {Math.Min(x,y)}");
Console.WriteLine($"\n Valor maximo entre x e y = {Math.Max(x,y)}");
Console.WriteLine($"\n Coseno de x = {Math.Cos(x)}");
Console.WriteLine($"\n Seno de x = {Math.Sin(x)}");
Console.WriteLine($"\n Exponencial de x = {Math.Exp(x)}");


Console.ReadKey();

//Console.WriteLine($"Soma de x + y = {x + y}");
//Console.WriteLine($"Subtração de x + y = {x - y}");
//Console.WriteLine($"Multiplicação de x + y = {x * y}");
//double divisao = (double)x / y;
//Console.WriteLine($"Divisão de x + y = {divisao}");
//Console.WriteLine($"Módulo de x + y = {x % y}");