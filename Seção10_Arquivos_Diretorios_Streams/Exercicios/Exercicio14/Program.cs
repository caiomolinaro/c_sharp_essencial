//Criar um programa que retorne o tamanho total de um diretório, incluindo todos os arquivos e
//subdiretórios, usando a classe Directory e a classe Path.

Console.WriteLine("Digite o diretorio que deseja saber o tamanho");
string diretorio = Console.ReadLine();
long tamanhoTotal = GetDirectorySize(diretorio);

Console.WriteLine($"Tamanho total do diretório {diretorio}: {tamanhoTotal} bytes");
Console.ReadKey();

static long GetDirectorySize(string diretorio)
{
  
    if (!Directory.Exists(diretorio))
    {
        throw new DirectoryNotFoundException($"Diretório {diretorio} não encontrado.");
    }
 
    long tamanhoTotal = 0;
    foreach (string arquivo in Directory.GetFiles(diretorio, "*",
    SearchOption.AllDirectories))
    {
        FileInfo info = new FileInfo(arquivo);
        tamanhoTotal += info.Length;
    }
    return tamanhoTotal;
}