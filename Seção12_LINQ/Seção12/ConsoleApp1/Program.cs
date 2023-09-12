IList<string> frutas = new List<String>() { "Banana", "Maça", "Pera", "Laranja", "Uva" };


//query syntas pra consulta

var resultado = from f in frutas
                where f.Contains("r") 
                select f;

Console.WriteLine(string.Join(", ", resultado));

//method syntax para consultas

var resultado1 = frutas.Where(f => f.Contains("r"));

Console.WriteLine(string.Join(", ",resultado1));


Console.ReadKey();