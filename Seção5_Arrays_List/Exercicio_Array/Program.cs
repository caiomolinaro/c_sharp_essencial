string[] nomes = new string [5];
double[] notas = new double[5];

for (int i = 0; i < 5; i++) 
{
    Console.WriteLine("Digite o nome do aluno");
    string? nome = Console.ReadLine();
    nomes[i] = nome;
}

Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite os notas do aluno");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
}

Console.WriteLine();


foreach (string nome in nomes)
{
    Console.WriteLine($"{nome}");
}

Console.WriteLine();

var somaNotas = 0.0;
var totalNotas = notas.Count();

Console.WriteLine();

foreach (double nota in notas)
{
    somaNotas += nota; 
    Console.WriteLine($"{nota}");
}

Console.WriteLine();

Console.WriteLine($"Media aritmetica : {somaNotas/totalNotas}");



Console.ReadKey();