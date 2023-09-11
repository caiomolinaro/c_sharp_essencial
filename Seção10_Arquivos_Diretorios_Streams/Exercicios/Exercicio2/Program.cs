//Escreva um programa que copie um arquivo de um diretório para outro. O nome e o caminho do arquivo de
//origem e destino devem ser fornecidos pelo usuário.

Console.WriteLine("Digite o caminho do arqivo de origem");
string arquivoOrigem = Console.ReadLine();

Console.WriteLine("Digite o caminho do arquivo de destino");
string arquivoDestino = Console.ReadLine();

Console.WriteLine("Digite o nome do aquivo copiado");
string aquivoNome = Path.GetFileName(Console.ReadLine());

try
{
    string arquivoCopia = Path.Combine(arquivoDestino, aquivoNome);

    File.Copy(arquivoOrigem, arquivoCopia, true);

    Console.WriteLine("Copiado com sucesso");
}
catch(IOException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

