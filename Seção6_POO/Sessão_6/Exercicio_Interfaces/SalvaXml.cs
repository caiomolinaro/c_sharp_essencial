namespace Exercicio_Interfaces
{
    public class SalvaXml : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvar arquivo em xml");
        }

        public override void Nome()
        {
            Console.WriteLine("Definir nome xml");
        }
    } 
}
