
var caminhoDiretorio = @"C:\Users\cmoli\OneDrive\Área de Trabalho\DEV\PROJETOS\c#_essencial\Seção10_Arquivos_Diretorios_Streams\MeuDiretorio";
var caminhoDestino = @"C:\Users\cmoli\OneDrive\Área de Trabalho\DEV\PROJETOS\c#_essencial\Seção10_Arquivos_Diretorios_Streams\MeuDiretorioNovo";


//criando um diretorio novo

//try
//{
//    if (!Directory.Exists(caminhoDiretorio))// verifica se o diretorio não(!) existe

//    {
//        Directory.CreateDirectory(caminhoDiretorio);
//        Console.WriteLine("Criado");
//    }
//    else
//    {
//        Console.WriteLine("Diretorio ja existe");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//excluindo
//try
//{
//    if (Directory.Exists(caminhoDiretorio))

//    {
//        Directory.Delete(caminhoDiretorio);
//        Console.WriteLine("Excluido");
//    }
//    else
//    {
//        Console.WriteLine("Diretorio não existe");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//obter os subdiretorios

//try
//{
//    if (Directory.Exists(caminhoDiretorio))

//    {
//        string[] subDiretorios = Directory.GetDirectories(caminhoDiretorio);
//        foreach (var subDir in subDiretorios)
//            Console.WriteLine(subDir);
//    }
//    else
//    {
//        Console.WriteLine("Diretorio não existe");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//obtendo todos arquivos em um diretorio

//try
//{
//    if (Directory.Exists(caminhoDiretorio))

//    {
//        string[] arquivos = Directory.GetFiles(caminhoDiretorio);
//        foreach (var listaArquivos in arquivos)
//            Console.WriteLine(listaArquivos);
//    }
//    else
//    {
//        Console.WriteLine("Diretorio não existe");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//copiar um diretorio
try
{
    if (Directory.Exists(caminhoDiretorio))

    {
        Directory.Move(caminhoDiretorio, caminhoDestino);
    }
    else
    {
        Console.WriteLine("Diretorio não existe");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



Console.ReadKey();