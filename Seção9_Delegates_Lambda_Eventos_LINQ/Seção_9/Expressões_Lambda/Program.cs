//é uma função anonima que pode ser usada para criar delegates ou expressoes de arvores de expressão

//definindo a função
//(parametros de entrada) => {expressão ou bloco de instrução}

List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("Carlos"); 


string resultado = nomes.Find (nome => nome.Equals("Paulo"));  //expressão lambda

Console.WriteLine(resultado);
Console.ReadKey();  