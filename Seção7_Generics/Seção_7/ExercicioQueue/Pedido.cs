﻿namespace ExercicioQueue
{
    public class Pedido
    {
        public Pedido(int numero, double valor)
        {
            Numero = numero;
            Valor = valor;
        }

        public int Numero { get; set; }
        public double Valor { get; set; }
    }
}
