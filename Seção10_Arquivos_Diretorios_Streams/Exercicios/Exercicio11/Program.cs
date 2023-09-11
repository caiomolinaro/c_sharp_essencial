//Criar um programa que liste todos os arquivos em um determinado diretório e suas subpastas usando a
//classe DirectoryInfo e a classe Path.

Console.WriteLine("Informe o diretorio pra listar os arquivos do dir");
string caminho = Console.ReadLine();

DirectoryInfo diretorio = new DirectoryInfo(caminho);

foreach(var arquivo in diretorio.GetFiles("*", SearchOption.AllDirectories))
    Console.WriteLine(arquivo.FullName);