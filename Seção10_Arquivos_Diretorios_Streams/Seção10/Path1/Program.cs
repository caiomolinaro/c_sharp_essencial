string path1 = @"C:\Users\cmoli\OneDrive\Área de Trabalho\DEV\PROJETOS\c#_essencial\Seção10_Arquivos_Diretorios_Streams\txt";
string path2 = @"\txt\arquivo1.txt";

string pathCombinado = Path.Combine(path1, path2);
Console.WriteLine(pathCombinado);

Console.WriteLine(Path.GetDirectoryName(pathCombinado));
Console.WriteLine(Path.GetExtension(pathCombinado));
Console.WriteLine(Path.GetFileName(pathCombinado));
Console.WriteLine(Path.GetFileNameWithoutExtension(pathCombinado));
Console.WriteLine(Path.HasExtension(pathCombinado));
Console.WriteLine(Path.IsPathRooted(pathCombinado));
Console.WriteLine(Path.ChangeExtension(pathCombinado, ".docx"));
Console.WriteLine(Path.GetPathRoot(pathCombinado));

Console.WriteLine();

Console.WriteLine(Path.GetRandomFileName());
Console.WriteLine(Path.GetTempFileName());
Console.WriteLine(Path.GetTempPath());

Console.WriteLine();

char[] caractersInvalidos = Path.GetInvalidFileNameChars();
Console.WriteLine(new string(caractersInvalidos));