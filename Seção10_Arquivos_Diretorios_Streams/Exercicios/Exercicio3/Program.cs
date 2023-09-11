//Escreva um programa que crie um arquivo e escreva algumas informações nele. Em seguida, abra o arquivo
//novamente e adicione mais algumas informações a ele. Em seguida, leia o conteúdo do arquivo e exiba-o na
//tela.

string arquivoCriado = @"C:\Users\Caio Molinaro\Desktop\Exercicios\Exercicios\arquivos\arquivo.txt";

//File.Create(arquivoCriado);

Console.WriteLine("Digite um texto pro arquivo");
string textoArquivo = Console.ReadLine();

File.WriteAllText(arquivoCriado, textoArquivo + "\r\n");
lerArquivo(arquivoCriado);

Console.WriteLine("Vamos escrever mais no arquivo");
string textoNovoArquivo = Console.ReadLine();

File.AppendAllText(arquivoCriado, textoNovoArquivo + "\r\n");

string conteudoArquivoNovo = File.ReadAllText(arquivoCriado);
Console.WriteLine("\nConteudo atualizado:\n");
lerArquivo(conteudoArquivoNovo);

static void lerArquivo(string lugarAquivo)
{
    Console.WriteLine("Conteudo do aquivo: ");
    string conteudoArquivo = File.ReadAllText(@"C:\Users\Caio Molinaro\Desktop\Exercicios\Exercicios\arquivos\arquivo.txt");
    Console.WriteLine(conteudoArquivo);
}