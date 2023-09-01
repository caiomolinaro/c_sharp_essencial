namespace Exercicio_Interfaces
{
    public interface ISalvar
    {
        void Salvar();
        void Compactar()
        {
            Console.WriteLine("Compactando arquivos");
        }
    }
}
