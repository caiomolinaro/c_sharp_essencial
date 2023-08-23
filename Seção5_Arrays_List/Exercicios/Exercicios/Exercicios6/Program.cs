//6 - Crie um programa C# e defina um método chamado ProcessaObjetos() que possa receber um número
//variáveis de argumentos e que possa exibir os seus valores e também o tipo do objeto (Use o método
//GetType() herdado de Object) no console.
//Passe os seguintes argumentos ao invocar o método : ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null)

ProcessaObjetos(1, "Caio", 3.10m, new Teste(), null);

Console.ReadKey();
static void ProcessaObjetos(params object[] vetor)
{
    Console.WriteLine("Exibir o conteudo do array de objetos");

    if(vetor != null)
    {
        foreach(var objeto in vetor)
        {
            Console.WriteLine($"Objeto: {objeto} \t Tipo: {objeto?.GetType()}");
        }
    }
}

class Teste
{ }