//eventos são mecanismos que permitem que uma classe ou objeto notifique outras classes ou objetos quando
//alguma ação ocorre

//a clase que envia/acioan o evento é chamada de publisher e as classes que recebem/manipulam são chamadas de subscribers

//no c# um evento é um delegate encapsulado e depende do delegate

using Eventos;

//usando o evento oncriarpedido
var pedido = new Pedido();

//inscrever os assinantes no evento
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido();

Console.ReadKey();

//criando o delegate para o evento
public delegate void PedidoEventHandler();