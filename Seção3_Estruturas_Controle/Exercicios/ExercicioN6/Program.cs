//6 - Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 maneiras diferentes:
//- Incrementando 2 em cada passo
//- Incrementando 1 em cada passo
//- Com e loop infinito (use "break" e "continue")

//incrmentando 2 em cada passo
for (int i = 10; i <= 20; i+=2)
{
    if (i == 16)
        continue;
    Console.WriteLine($"i = {i}");
}

//incrementando 1 em cada passo
for(int a = 10; a <= 20; a++)
{
    if (a % 2 ==1)
        continue;
    if (a == 16)
        continue;
    Console.WriteLine($"a = {a}");
}

//com loop infinito
for (int b = 10; ; b+=2)
{
    if(b == 16)
        continue;
    if (b > 20)
        break;
    Console.WriteLine($"B = {b}");
}