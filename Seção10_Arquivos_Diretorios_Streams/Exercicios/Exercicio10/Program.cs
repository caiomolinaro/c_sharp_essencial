//Criar um programa que permita ao usuário mover um arquivo de um diretório para outro usando a classe File
//e a classe Path.

string caminhoOrigem = @"C:\Users\Username\Documents\Origem\Arquivo.txt";
string caminhoDestino = @"C:\Users\Username\Documents\Origem\Destino";
string nomeArquivo = Path.GetFileName(caminhoOrigem);

string caminhoDestinoCompleto = Path.Combine(caminhoDestino, nomeArquivo);

File.Move(caminhoOrigem, caminhoDestinoCompleto);