using Syntax_Metodo_Consulta;


var numeros = FonteDados.GetNumeros();

var resultado1 = numeros.Where(n => n < 10);
Console.WriteLine(String.Join(" ", resultado1));

var resultado2 = numeros.Where(n => n > 1 && n != 4 && n < 20);
Console.WriteLine(String.Join(" ", resultado2));

var listaNegra = FonteDados.GetListaNegra();

var resultado3 = numeros.Where(n => !listaNegra.Contains(n));
 
var resultado4 = numeros.Where(n => n >1 )
                        .Where(n => n != 4)
                        .Where(n => n > 20);

Console.WriteLine(String.Join(" ", resultado3));

Console.ReadKey();

