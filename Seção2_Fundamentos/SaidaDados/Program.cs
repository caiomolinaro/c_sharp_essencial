Console.WriteLine("Saída de dados: Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.Write(nome);
Console.Write(idade);
Console.WriteLine();

//Escreve na mesma linha 'Maria tem 25 anos, usando o operador +'
Console.WriteLine(nome + " tem " + idade + " anos");
Console.Write(nome + " tem " + idade + " anos");
Console.WriteLine();


//usar a interpolação de strings:
Console.WriteLine($"{nome} tem {idade} anos");
Console.WriteLine();


//usar place holders : usa {} com numeraço com inicio em zero
Console.WriteLine("{0} tem {1} anos", nome, idade);


Console.ReadLine();