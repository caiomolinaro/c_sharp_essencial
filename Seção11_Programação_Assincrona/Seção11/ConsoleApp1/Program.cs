int espera = 4000;

Console.WriteLine("Tecle pra iniciar");

RealizarTarefa(espera);

Console.WriteLine($"Tempo gasto: {espera / 1000} segundos");

Console.ReadKey();

static void RealizarTarefa(int tempo)
{
    Console.WriteLine("Iniciando a tarefa");
    Thread.Sleep(tempo);
    Console.WriteLine("Concluido");
}