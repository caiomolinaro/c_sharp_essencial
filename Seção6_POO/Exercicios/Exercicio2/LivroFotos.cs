namespace Exercicio2
{
    public class LivroFotos
    {
        protected int numPaginas { get; set; }

        public LivroFotos()
        {
            numPaginas = 16;
        }

        public LivroFotos (int numPaginas)
        {
            this.numPaginas = numPaginas;
        }

        public int GetNumeroPaginas()
        {
            return numPaginas;
        }
    }
}
