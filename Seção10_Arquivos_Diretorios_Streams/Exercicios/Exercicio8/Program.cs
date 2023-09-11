//Criar um programa que permita ao usuário criar um novo diretório e, em seguida, criar um arquivo dentro
//desse diretório usando a classe Directory e a classe Path.

Console.WriteLine("Informe o diretorio onde deseja criar o arquivo");
string caminhoArquivo = Console.ReadLine();

string nomeArquivo = "NovoArquivo.txt";

Directory.CreateDirectory(caminhoArquivo);

string caminhoCompleto = Path.Combine(caminhoArquivo, nomeArquivo);
File.Create(caminhoCompleto);
