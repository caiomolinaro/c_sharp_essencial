//Criar um programa que liste todos os subdiretórios em um determinado diretório usando a classe
//DirectoryInfo.

Console.WriteLine("Digite o diretorio que quer listar os sub diretorios");
string caminho = Console.ReadLine();
DirectoryInfo diretorio = new DirectoryInfo(caminho);
    foreach (var subdiretorio in diretorio.GetDirectories())
    Console.WriteLine(subdiretorio.Name);