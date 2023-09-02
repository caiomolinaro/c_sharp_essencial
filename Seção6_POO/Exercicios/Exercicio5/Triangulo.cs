namespace Exercicio5
{
    public class Triangulo : Forma
    {
        private double Base {  get; set; }
        private double Altura { get; set; }

        public Triangulo(double b, double a)
        {
            Base = b;
            Altura = a;
        }

        public override double Area()
        {
            return (0.5 * Base * Altura);
        }
    }
}
