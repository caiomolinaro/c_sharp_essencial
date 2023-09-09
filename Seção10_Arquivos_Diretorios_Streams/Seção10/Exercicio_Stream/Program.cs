string caminhoArquivo = @"C:\Users\cmoli\OneDrive\Área de Trabalho\DEV\PROJETOS\c#_essencial\Seção10_Arquivos_Diretorios_Streams\dados\exercicio.txt";


while (true)
{
    Console.WriteLine("1 - cria arquivo");
    Console.WriteLine("2 - gravar em arquivo");
    Console.WriteLine("3 - le arquivo");
    Console.WriteLine("4 - procurar texto em arquivo");
    Console.WriteLine("0 - sair");

    int opcao = Convert.ToInt32(Console.ReadLine());

    switch(opcao)
    {
        case 0:
            return;
        case 1:
            CriarArquivo(caminhoArquivo);
            break;
        case 2:
            GravarEmArquivo(caminhoArquivo);
            break;
        case 3:
            LerArquivo(caminhoArquivo);
            break;
        case 4:
            ProcurarTexto(caminhoArquivo);
            break;
        default:
            Console.WriteLine("opçao invalida");
            break;
    }
}


static void CriarArquivo(string caminhoArquivo)
{
    try
    {
        using (FileStream fs = new FileStream(caminhoArquivo, FileMode.Create, FileAccess.Write));
        {
            Console.WriteLine("Arquivo criado");
        }
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void GravarEmArquivo(string caminhoArquivo)
{
    Console.WriteLine("Digite o texto que vai ser gravado");
    string? texto = Console.ReadLine();

    try
    {
        using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
        {
            writer.WriteLine(texto);
        }
        Console.WriteLine("Texto gravado");
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void LerArquivo(string caminhoArquivo)
{
    if(!File.Exists(caminhoArquivo))
    {
        Console.WriteLine("Não existe esse arquivo");
        return;
    }
    try
    {
        using(StreamReader reader = new StreamReader(caminhoArquivo)) 
        {
            string linha;
            while((linha = reader.ReadLine()) != null) 
            {
                Console.WriteLine(linha);
            }
        }
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void ProcurarTexto(string caminhoArquivo)
{
    Console.WriteLine("Digite o texto que quer encontrar");
    string textoProcurado = Console.ReadLine();

    if (!File.Exists(caminhoArquivo))
    {
        Console.WriteLine("Não existe esse arquivo");
        return;
    }
    try
    {
        bool encontrado = false;
        using (StreamReader reader = new StreamReader(caminhoArquivo))
        {
            string linha;
            int numLinha = 0;
            while ((linha = reader.ReadLine()) != null)
            {
                numLinha++;
                if(linha.Contains(textoProcurado)) 
                {
                    Console.WriteLine($"Texto encontrado na linha {numLinha} : {linha}");
                    encontrado = true;
                    break;
                }
            }
        }
        if( ! encontrado )
            Console.WriteLine("Não encontrei esse texto :(");

    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
