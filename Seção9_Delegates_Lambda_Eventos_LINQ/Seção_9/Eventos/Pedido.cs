namespace Eventos
{
    public class Pedido
    {
        public event PedidoEventHandler? OnCriarPedido;
        public void CriarPedido()
        {
            Console.WriteLine("Pedido Criado");
            if(OnCriarPedido != null)
            {
                OnCriarPedido();
            }
        }
    }
}
