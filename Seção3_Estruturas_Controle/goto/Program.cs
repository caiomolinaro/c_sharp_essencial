int i = 1;

repetir:
Console.WriteLine(i);
i++;

if (i <= 10)
    goto repetir;

Console.ReadKey();