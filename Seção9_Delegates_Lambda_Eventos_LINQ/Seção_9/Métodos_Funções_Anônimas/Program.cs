//uma função anonimca é uma função que não possui nome e que pode ser definida usando a palavra-chave delegate 
//e pode ser atribuida a uma variavel do tipo delegate
//é uma declaração "in line" ou expressão que pode ser usada sempre que um tipo de delegate for esperado

//existem dois tipos:
//métodos anomimos
//funções lambdas


//Imprimir imprimir = delegate (int valor)
//{
//    Console.WriteLine($"Metodo anonimo {valor}");
//};

//imprimir(100);
//imprimir(200);

List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("Carlos");


string resultado = nomes.Find(delegate (string nome)
{
    Console.WriteLine($"Checando nomes: {nome}");
    return nome.Equals("Paulo");
});

Console.WriteLine(resultado);


Console.ReadKey();

//public delegate void Imprimir(int valor);