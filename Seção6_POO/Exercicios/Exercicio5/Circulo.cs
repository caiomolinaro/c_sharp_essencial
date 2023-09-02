﻿namespace Exercicio5
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }
        public Circulo (double raio)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return (Math.PI * Raio * Raio);
        }
    }
}
