//Escreva um programa que leia um caminho de arquivo do usuário e, em seguida, verifique se o arquivo existe. 
//Se o arquivo existir, mostre a data de criação do arquivo, caso contrário, exiba uma mensagem informando que o arquivo não foi encontrado.

Console.WriteLine("Digite o caminho do arquivo");
string caminhoArquivo = Console.ReadLine();

if(File.Exists(caminhoArquivo))
{
    FileInfo info = new FileInfo(caminhoArquivo);
    Console.WriteLine(info.CreationTime);
}
else
{
    Console.WriteLine("Diretorio não encontrado");
}


Console.ReadKey();  