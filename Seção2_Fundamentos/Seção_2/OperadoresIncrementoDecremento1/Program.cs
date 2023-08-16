Console.WriteLine("Operadores incremento e decremento \n");


int x = 0;
Console.WriteLine($"x = {x}");

//pós incremento
int resultado1 = x++ + 10;
Console.WriteLine(resultado1);
Console.WriteLine($"valor de x = {x}");

//pré incremento
int y = 0;
Console.WriteLine($"y = {y}");


int resultado2 = ++y + 10;
Console.WriteLine(resultado2);
Console.WriteLine($"valor de y = {y}");

//*-----*

int a = 0;
Console.WriteLine($"x = {x}");

//pós decremento
int resultado3 = a-- + 10;
Console.WriteLine(resultado3);
Console.WriteLine($"valor de a = {a}");

//pré incremento
int b = 0;
Console.WriteLine($"b = {b}");


int resultado4 = --b + 10;
Console.WriteLine(resultado4);
Console.WriteLine($"valor de b = {b}");

Console.ReadKey();