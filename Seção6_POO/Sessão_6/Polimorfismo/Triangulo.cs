﻿namespace Polimorfismo
{
    public class Triangulo : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando o triangulo");
            base.Desenhar();
        }
    }
}
