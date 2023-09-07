using System.Runtime.Serialization;

namespace Exercicio4
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string? message) : base(message)
        {
        }

        public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
