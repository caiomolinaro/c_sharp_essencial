//criando a fila 
using ExercicioQueue;

Queue<Pedido> filaPedidos = new Queue<Pedido>();

//add pedidos na fila
filaPedidos.Enqueue(new Pedido(101, 10.0));
filaPedidos.Enqueue(new Pedido(201, 20.0));
filaPedidos.Enqueue(new Pedido(301, 30.0));



//exibir o numero de pedidos na fila

Console.WriteLine($"numeros de pedidos na fila {filaPedidos.Count}");

//processar os pedidos da fila

while(filaPedidos.Count > 0)
{
    //retirar o proximo pedido da fila
    Pedido proximoPedido = filaPedidos.Dequeue();

    Console.WriteLine($"Processando pedido: {proximoPedido.Numero} valor {proximoPedido.Valor}");
}

//add mais pedidos a fila
filaPedidos.Enqueue(new Pedido(401, 40.0));
filaPedidos.Enqueue(new Pedido(501, 50.0));
filaPedidos.Enqueue(new Pedido(601, 60.0));



//localizar um pedido na fila
int numeroPedido = 501;
Pedido? pedidoLocalizado = filaPedidos.FirstOrDefault(p=> p.Numero == numeroPedido);

if(pedidoLocalizado != null)
    Console.WriteLine($"Pedido {numeroPedido} localizado na fila valor {pedidoLocalizado.Valor}");
else
    Console.WriteLine($"Pedido {numeroPedido} não localizado na fila");






















Console.ReadKey();  