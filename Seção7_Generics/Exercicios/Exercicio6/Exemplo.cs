namespace Exercicio6
{
    public class Exemplo
    {
        public static void ReverterEImprimir<T>(T[] array)
        {
            Array.Reverse(array);
            Console.WriteLine("Array revertido");

            foreach(T item in array) 
                Console.WriteLine(item + " ");

            Console.WriteLine();
        }
    }
}
