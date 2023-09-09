string caminhoOrigem = @"C:\Users\cmoli\OneDrive\Área de Trabalho\DEV\PROJETOS\c#_essencial\Seção10_Arquivos_Diretorios_Streams\arquivo1.txt";
string caminhoDestino = @"C:\Users\cmoli\OneDrive\Área de Trabalho\DEV\PROJETOS\c#_essencial\Seção10_Arquivos_Diretorios_Streams\txt\arquivo1.txt";


//criar arquivo
//File.Create(caminhoOrigem);


if (!File.Exists(caminhoDestino))
{

    File.WriteAllText(caminhoOrigem, "Caio Molinaro \r\n");

    string novoTexto = "O poeta é um fingidor " +
                        Environment.NewLine +
                        "Finge tão completamente \r\n" +
                        "Que chega a fingir que é dor\r\n" +
                        "A dor que deveras sente.\r\n";

    File.AppendAllText(caminhoOrigem, novoTexto);

    //le o conteudo do arquivo

    Console.WriteLine("\nConteudo do arquivo");

    string conteudo = File.ReadAllText(caminhoOrigem);
    Console.WriteLine(conteudo);


    //ultima modificação feita no arquivo
    Console.WriteLine(File.GetLastWriteTime(caminhoOrigem));

    //ultimo acesso feito no arquivo
    Console.WriteLine(File.GetLastAccessTime(caminhoOrigem));

    //ler o conteudo armazenando num array de string
    string[] linhas = File.ReadAllLines(caminhoOrigem);
    foreach (var linha in linhas)
        Console.WriteLine(linha);


    //copiar arquivos:
    var caminhoCopia = @"C:\Users\cmoli\OneDrive\Área de Trabalho\DEV\PROJETOS\c#_essencial\Seção10_Arquivos_Diretorios_Streams\arquivo1_copia.txt";
    File.Copy(caminhoOrigem, caminhoCopia, true);

    //mover arquivo
    File.Move(caminhoOrigem, caminhoDestino, true);

    //excluindo arquivos
    //File.Delete(caminhoOrigem);
    //File.Delete(caminhoDestino);
    //File.Delete(caminhoCopia);
}
else
{
    Console.WriteLine("Bye");
}
Console.ReadKey();

