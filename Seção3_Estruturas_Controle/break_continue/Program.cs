//for(; ; )
//{
//    Console.WriteLine("Tecle algo (x) sai");
//    var opcao = Console.ReadLine();

//    Console.WriteLine(opcao.ToUpper());

//    if ( opcao == "X" ||  opcao == "x")
//    {
//        Console.WriteLine("Tchau");
//        break;
//    }
//}

for(int i = 1; i < 10; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
}
Console.ReadKey();