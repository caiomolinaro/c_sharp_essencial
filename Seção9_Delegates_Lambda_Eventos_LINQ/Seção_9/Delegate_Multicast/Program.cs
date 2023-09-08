//Tem dois tipos de delegate:
//singlecast delegate = referencia e invoca um unico metodo
//multicast delegate = referencia e invoca mais de um metodo

MeuDelegate delegateMulticast = new MeuDelegate(Metodo1);
delegateMulticast += Metodo2; //adicionando mais um metodo
delegateMulticast += Metodo3;

delegateMulticast("Olá multicast delegate =D");

delegateMulticast -= Metodo3; //remove um delegate ja registrado no multicast
delegateMulticast("O Metodo 3 foi removido =(");

Console.ReadKey();

static void Metodo1(string mensagem)
{
    Console.WriteLine("Método 1: " + mensagem);
}
static void Metodo2(string mensagem)
{
    Console.WriteLine("Método 2: " + mensagem);
}
static void Metodo3(string mensagem)
{
    Console.WriteLine("Método 3: " + mensagem);
}

public delegate void MeuDelegate(string mensagem);