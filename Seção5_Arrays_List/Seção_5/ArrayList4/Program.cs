using System.Collections;

//var lista = new ArrayList()
//                         {
//                           "Ana", 5, true, " ", null, 1.1, "Zé", 3, 9, 0
//                         };


//var res1 = lista.Contains(5);
//bool res2 = lista.Contains("Mari");

//Console.WriteLine(res1);
//Console.WriteLine(res2);
//Console.WriteLine(lista.Contains(null));

var lista = new ArrayList()
                         {
                           "Maria", "José", "Douglas", "Caio", "Fernanda"
                         };

lista.Sort();

foreach (var item in lista)
{
    Console.WriteLine(item);
}

Console.ReadKey();

//Verificar se um elemnto está na coleção:
//Metodo Contains() - Retorna True ou False

//Ordenar e remover elementos:
//Metodo Sort() - ordena em ordem ascendente
//Metodo Clear() - removo todos os elementos