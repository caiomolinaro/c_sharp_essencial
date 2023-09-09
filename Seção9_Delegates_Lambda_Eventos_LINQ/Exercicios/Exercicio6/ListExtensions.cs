namespace Exercicio6
{
    public static class ListExtensions
    {
        public static int SomaImpar(this List<int> list)
        {
            int soma = 0;
            foreach (int n in list)
            {
                if (n % 2 == 1)
                    soma+=n;
            }
            return soma;
        }
    }
}
