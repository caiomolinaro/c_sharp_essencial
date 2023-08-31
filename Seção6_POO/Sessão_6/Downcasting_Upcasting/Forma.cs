namespace Downcasting_Upcasting
{
    public class Forma
    {
        protected int xpos, ypos;

        public Forma()
        { }

        public Forma(int x, int y)
        {
            xpos = x;
            ypos = y;
        }

        public virtual void Desenhar()
        {
            Console.WriteLine($"Desenhar - forma na pocição: ({xpos},{ypos}");
        }
    }
}
