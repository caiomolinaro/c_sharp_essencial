string caminho = "C:\\Users\\cmoli\\OneDrive\\Área de Trabalho\\DEV\\PROJETOS\\c#_essencial\\Seção10_Arquivos_Diretorios_Streams\\txt";

char dirSeparador = Path.DirectorySeparatorChar;
Console.WriteLine(dirSeparador);

string[] diretorios = caminho.Split(dirSeparador);
foreach (var item in diretorios)
{
    Console.WriteLine(item);
}

P


Console.ReadKey();