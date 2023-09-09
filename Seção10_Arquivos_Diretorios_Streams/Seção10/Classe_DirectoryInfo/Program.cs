var caminhoDiretorio = @"C:\Users\cmoli\OneDrive\Área de Trabalho\DEV\PROJETOS\c#_essencial\Seção10_Arquivos_Diretorios_Streams\";

var dirOrigem = new DirectoryInfo(caminhoDiretorio);

Console.WriteLine(dirOrigem.Name);
Console.WriteLine(dirOrigem.FullName);
Console.WriteLine(dirOrigem.CreationTime);
Console.WriteLine(dirOrigem.LastAccessTime);
Console.WriteLine(dirOrigem.LastWriteTime);
Console.WriteLine(dirOrigem.Attributes);


//criando um novo diretorio

var novoDiretorio = new DirectoryInfo(@"C:\Users\cmoli\OneDrive\Área de Trabalho\DEV\PROJETOS\c#_essencial\Seção10_Arquivos_Diretorios_Streams\dadosNovo");
//try
//{
//    if(!novoDiretorio.Exists)
//    {
//        novoDiretorio.Create();
//        Console.WriteLine("Criado");
//    }
//    else
//    {
//        Console.WriteLine("Ja existe");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//excluindo

//try
//{
//    if (novoDiretorio.Exists)
//    {
//        novoDiretorio.Delete();
//        Console.WriteLine("Deletado");
//    }
//    else
//    {
//        Console.WriteLine("Não existe");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//listando os subdiretorios
Console.WriteLine();
try
{
    foreach(var subDir in dirOrigem.GetDirectories())
        Console.WriteLine(subDir.Name);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine();
//listando os arquivos
try
{
    foreach (var arquivo in dirOrigem.GetFiles())
        Console.WriteLine(arquivo.Name);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//criando um subdiretorio

try
{
    dirOrigem.CreateSubdirectory("Novo subdiretorio");
    Console.WriteLine("Foi criado");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();