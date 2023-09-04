



public class ClasseGenerica<T>
{
    T[] obj = new T[5];
    int contador = 0;

    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador] = item;
        }
        contador++;
    }

    public T this[int index]
    {
        get { return obj[contador]; }
        set { obj[index] = value; }
    }
}