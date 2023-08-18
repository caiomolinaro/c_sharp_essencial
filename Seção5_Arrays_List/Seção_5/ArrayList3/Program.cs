using System.Collections;

var lista = new ArrayList() 
                         { 
                           "Ana", 5, true, " ", null, 1.1, "Zé", 3, 9, 0 
                         };

lista.Remove(null);

lista.RemoveAt(4);

lista.RemoveRange(0, 2);

Console.ReadKey();

//Remover elementos
//Remove(Object Value) - Remove a primeira ocorrencia de um objeto especifico
//RemoveAt(int index) - Remove o elemento no indice especificado
//RemoveRange(int index, int count) - Remove um número definido de elementos a partir de um indice especificado