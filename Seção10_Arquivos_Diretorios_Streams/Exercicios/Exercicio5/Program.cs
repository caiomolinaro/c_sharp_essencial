//Escreva um programa que leia o conteúdo de um arquivo de imagem e converta-o para um arquivo de texto
//usando o algoritmo de codificação Base64. Em seguida, salve o arquivo de texto em um novo arquivo. O
//nome do arquivo de origem e destino deve ser fornecido pelo usuário.

Console.WriteLine("Digite o caminho do arquivo de imagem de origem");
string imagePath = Console.ReadLine();

Console.WriteLine("Digite o caminho do arquivo de destino");
string textFilePath = Console.ReadLine();

byte[] imageBytes = File.ReadAllBytes(imagePath);

string base64String = Convert.ToBase64String(imageBytes);

File.WriteAllText(textFilePath, base64String);
Console.WriteLine("Arquivo de texto salvo com sucesso!");