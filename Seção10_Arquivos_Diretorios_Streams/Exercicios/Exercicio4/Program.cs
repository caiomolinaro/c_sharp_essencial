//Escreva um programa que leia o conteúdo de um arquivo de texto e o criptografe usando o algoritmo de
//criptografia AES. Em seguida, salve o arquivo criptografado em um novo arquivo. O nome do arquivo de
//origem e destino deve ser fornecido pelo usuário.

using System.Security.Cryptography;
using System.Text;
using System;

Console.Write("Digite o caminho do arquivo de origem: ");
string caminhoOrigem = Console.ReadLine();
Console.Write("Digite o caminho do arquivo de destino: ");
string caminhoDestino = Console.ReadLine();

string chave = "minhachave12345678";
string conteudo = File.ReadAllText(caminhoOrigem);
byte[] conteudoCriptografado;
using (Aes aes = Aes.Create())
{
    aes.Key = Encoding.UTF8.GetBytes(chave);
    aes.Mode = CipherMode.CBC;
    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
    using (MemoryStream memoryStream = new MemoryStream())
    {
        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor,
        CryptoStreamMode.Write))
        {
            using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
            {
                streamWriter.Write(conteudo);
            }
            conteudoCriptografado = memoryStream.ToArray();
        }
    }
}
File.WriteAllBytes(caminhoDestino, conteudoCriptografado);
Console.WriteLine("Arquivo criptografado com sucesso.");