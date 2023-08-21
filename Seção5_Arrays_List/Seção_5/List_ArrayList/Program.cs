using System.Collections;

ArrayList lista = new ArrayList();

lista.Add(3);
lista.Add(4);

var elemento = lista[0];
int numero = (int) lista[1];



List<int> lista1 = new List<int>();
lista1.Add(1);

var item = lista1[0];

Console.ReadKey();

//A List<T> é mais segura e rápida que a ArrayList especialmente
//quando os itens da lista são de tipo de valor