List<string> frutas = new() 
{
"Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango" 
};


var fruta1 = frutas.Find(i => i.Contains('n')); // expressão lambda 

Console.WriteLine(fruta1);

Console.ReadKey();


// => operador de expressão lambda
