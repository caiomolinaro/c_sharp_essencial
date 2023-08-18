using System.Collections;

//var lista = new ArrayList() { "Maria S", 5, true, " ", null };


//lista.Add(3.5);

//lista.Insert(2, "Paulo");

//Console.WriteLine(lista[2]);

//Console.ReadKey();

var lista = new ArrayList() { "Maria", 5, true };

int[] array1 = { 1, 2, 3 };

lista.AddRange(array1);

lista.InsertRange(2, array1);

Console.ReadKey();

//adicionar elementos na arraylist 
//metodo Add = adiciona um unico elemento no final
//metodo Insert = adiciona um elemento em uma posição qualquer usando um indice especifico

//AddRange(ICollection) - Adiciona a coleção de elementos ao final do ArrayList
//InsertRange(int index, ICollection) - Adiciona a coleção de elemntos na ArrayList na posição do indice especificado