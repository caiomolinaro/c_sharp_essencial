using Classe_Abstrata;

Quadrado q = new Quadrado();
Console.WriteLine(q.Descricao());

Console.WriteLine("Informe a cor da figura");
q.Cor = Console.ReadLine();

Console.WriteLine("Informe o valor do lado do quadrado");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"Area do quadrado {q.Area}²");
Console.WriteLine($"Perimetro do quadradro {q.Perimetro} m");

Console.WriteLine($"O quadrado tem a cor: {q.Cor}");

Console.ReadKey();

//O modificador abstract indica que o recurso que está sendo modificado tem uma implementação ausente ou imcompleta
//Pode ser usado com classes, métodos, propriedades, indexadores e eventos 
//Usar ele numa declaração de classe indica que a classe destina a ser apenas uma classe base de outras classes, não podendo ser instanciada    