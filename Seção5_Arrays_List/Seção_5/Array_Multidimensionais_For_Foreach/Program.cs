﻿int[,] n = { 
             { 11, 22, 33 }, 
             { 44, 55, 66 }, 
             { 77, 88, 99 } 
           };

//usando o for:

for (int i = 0; i < n.GetLength(0); i++)
{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        Console.WriteLine($"{n[i, j]}");
    }
}

Console.WriteLine();

//usando foreach
foreach(int x in n)
{
    Console.WriteLine(x);
}

Console.ReadKey();