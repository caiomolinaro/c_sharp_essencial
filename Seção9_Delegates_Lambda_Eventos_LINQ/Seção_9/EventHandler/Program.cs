//delegates pre definidos:

//eventhandler = representa um método que vai manipular um evento que não possuio dados
//public delegate void eventhandler(objet? sender, eventargs e);

//eventhandler<teventargs> = representa um metodo que vai manipular um evento que possui dados
//public delegate void eventhandler<teventargs>(object? sender, teventsargs e);

var pedido = new Pedido();

pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido();

Console.ReadKey();

//criando o delegate para o evento

class Pedido
{
    public event EventHandler? OnCriarPedido;
    public void CriarPedido()
    {
        Console.WriteLine("Pedido Criado");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, EventArgs.Empty); 
        }
    }
}

class Email
{
    public static void Enviar(object? sender, EventArgs e)
    {
        Console.WriteLine("Enviando um email");
    }
}

class SMS
{
    public static void Enviar(object? sender, EventArgs e)
    {
        Console.WriteLine("Enviando um sms");
    }
}
