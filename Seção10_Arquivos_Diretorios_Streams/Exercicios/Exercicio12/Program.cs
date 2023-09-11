//Criar um programa que permita ao usuário excluir um arquivo ou diretório usando a classe Directory, a
//classe DirectoryInfo e a classe Path.

bool condicao = true;

while(condicao == true)
{
    Console.WriteLine("Informe a opção: ");
    Console.WriteLine("1 - excluir diretorio");
    Console.WriteLine("2- excluir arquivo");

    int opcao = Convert.ToInt32(Console.ReadLine());

    switch(opcao)
    {
        case 1:
            Console.WriteLine("Digite o caminho do diretorio que deseja excluir");
            string caminhoDiretorio = Console.ReadLine();
            Directory.Delete(caminhoDiretorio);
            condicao = false;
            break;   
            
        case 2:
            Console.WriteLine("Digite o caminho do arquivo que deseja excluir");
            string caminhoArquivo = Console.ReadLine();
            File.Delete(caminhoArquivo);
            condicao = false;
            break;

        default:
            Console.WriteLine("Digitou algo errado");
            condicao = false;
            break;
    }

}