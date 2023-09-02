namespace Exercicio5
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }

        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public override double Area()
        {
            return (Lado * Lado);
        }
    }
}
