//Criar um programa que retorne o nome do arquivo mais recente em um diretório usando a classe
//DirectoryInfo e a classe Path.

Console.WriteLine("Digte o diretorio que deseja ver o arquivo mais recente");
string diretorio = Console.ReadLine();

DirectoryInfo dirInfo = new DirectoryInfo(diretorio);
FileInfo[] arquivos = dirInfo.GetFiles();
DateTime ultimaModificacao = DateTime.MinValue;
string nomeArquivoMaisRecente = string.Empty;

foreach (FileInfo arquivo in arquivos)
{
    if (arquivo.LastWriteTime > ultimaModificacao)
    {
        ultimaModificacao = arquivo.LastWriteTime;
        nomeArquivoMaisRecente = arquivo.Name;
    }
}
if (!string.IsNullOrEmpty(nomeArquivoMaisRecente))
{
    Console.WriteLine($"O arquivo mais recente em {diretorio} é: {Path.Combine(diretorio, nomeArquivoMaisRecente)}");
}
else
{
    Console.WriteLine($"Não foi encontrado nenhum arquivo em {diretorio}");
}