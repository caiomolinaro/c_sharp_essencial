//Criar um programa que liste todos os arquivos em um determinado diretório usando a classe Directory e a
//classe Path.

Console.WriteLine("Digite o diretorio que quer listar os arquivos");
string caminho = Console.ReadLine();

string[] arquivos = Directory.GetFiles(caminho);
foreach (string arquivo in arquivos)
    Console.WriteLine(Path.GetFileName(arquivo));