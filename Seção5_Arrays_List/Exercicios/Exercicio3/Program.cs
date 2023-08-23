//3-Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo float , para 10
//alunos divididos em 2 grupos de 5 alunos cada. Armazene as informações em um array bidimensional e a
//seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).

int totalGrupoAlunos = 2;
int totalPorGrupoAlunos = 5;


float[,] notas = new float[totalGrupoAlunos, totalPorGrupoAlunos];

float totalPorGrupo1 = 0.0f, totalPorGrupo2 = 0.0f;

//recebe as notas e armazena
for (int i = 0; i < totalGrupoAlunos; i++)
{
    Console.WriteLine($"Informe a nota do grupo: {i + 1}");
    for (int j = 0; j < totalPorGrupoAlunos; j++)
    {
        Console.WriteLine($"Nota : [{i},{j}]");
        notas[i, j] = Convert.ToSingle(Console.ReadLine());
    }
}

//calculo das medias do primeiro grupo
for (int i = 0; i < totalPorGrupoAlunos; i++)
{
    totalPorGrupo1 += notas[0, i];
}

Console.WriteLine($"Média do grupo 1: {totalPorGrupo1 / totalPorGrupoAlunos}");

//calculo das medias do segundo grupo

for (int i = 0; i < totalPorGrupoAlunos; i++)
{
    totalPorGrupo2 += notas[1, i];
}

Console.WriteLine($"Média do grupo 2: {totalPorGrupo2 / totalPorGrupoAlunos}");