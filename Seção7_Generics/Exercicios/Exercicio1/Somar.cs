namespace Exercicio1
{
    public class Somar <T> where T : struct, IComparable, IConvertible, IFormattable
    {
        public T SomaNumeros(T n1, T n2) 
        {
            dynamic num1 = n1;
            dynamic num2 = n2;
            return num1 + num2;
        }
    }
}
