//delegates pre definidos:

//eventhandler<teventargs> = representa um metodo que vai manipular um evento que possui dados
//public delegate void eventhandler<teventargs>(object? sender, teventsargs e);

var pedido = new Pedido();

pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido("email@email.com", "(11) 12345-6789");

Console.ReadKey();
//cria a classe que herda de eventargs e define as propriedades email e telefone que representam os dados
//que desejamos passar no evento
class PedidoEventArgs : EventArgs
{
    public string? Email { get; set; }
    public string? Telefone { get; set; }
}

class Pedido
{
    public event EventHandler<PedidoEventArgs> OnCriarPedido;
    public void CriarPedido(string email, string telefone)
    {
        Console.WriteLine("Pedido Criado");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, new PedidoEventArgs { Email = email, Telefone = telefone });
        }
    }
}

class Email 
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Enviando um email para: {e.Email}");
    }
}

class SMS
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Enviando um sms para: {e.Telefone}");
    }
}

