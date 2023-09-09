
var caminhoOrigem = @"C:\Users\cmoli\OneDrive\Área de Trabalho\DEV\PROJETOS\c#_essencial\Seção10_Arquivos_Diretorios_Streams\poesia.txt";
var caminhoDestino = @"C:\Users\cmoli\OneDrive\Área de Trabalho\DEV\PROJETOS\c#_essencial\Seção10_Arquivos_Diretorios_Streams\dados\poesia.txt";
var caminhoCopia = @"C:\Users\cmoli\OneDrive\Área de Trabalho\DEV\PROJETOS\c#_essencial\Seção10_Arquivos_Diretorios_Streams\poesia_copia.txt";


FileInfo arquivoOrigem = new FileInfo(caminhoOrigem);

Console.WriteLine("Nome do arquivo: " + arquivoOrigem.Name);

Console.WriteLine("Caminho completo do arquivo: " + arquivoOrigem.FullName);

Console.WriteLine("É somene leitura? " + arquivoOrigem.IsReadOnly);

var diretorioPai = arquivoOrigem.Directory;
Console.WriteLine("Nome do diretorio " + diretorioPai.Name);

Console.WriteLine("Tamanho do arquivo: " + arquivoOrigem.Length);

Console.WriteLine("Ultima gravação: " + arquivoOrigem.LastWriteTime);

if (arquivoOrigem.Exists)
{
    arquivoOrigem.CopyTo(caminhoCopia);
}
else
{
    Console.WriteLine("Não existe");
}

//movendo pra outro lugar
arquivoOrigem.MoveTo(caminhoDestino);

Console.ReadKey();