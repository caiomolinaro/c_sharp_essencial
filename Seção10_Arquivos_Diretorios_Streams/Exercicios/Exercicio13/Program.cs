//Criar um programa que renomeie um arquivo usando a classe File e a classe Path.

Console.WriteLine("Digite o caminho do arquivo que deseja renomer");
string caminhoArquivo = Console.ReadLine();

string novoNome = "NovoNome.txt";

string caminhoCompleto = Path.Combine(Path.GetDirectoryName(caminhoArquivo), novoNome);

File.Move(caminhoArquivo, caminhoCompleto);