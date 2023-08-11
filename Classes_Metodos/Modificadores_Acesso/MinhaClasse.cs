using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores_Acesso
{
    internal class MinhaClasse
    {
        int MeuCampo;

        string? MinhaPropriedade { get; set; }

        void meuMetodo()
        {
            Console.WriteLine("Meu metodo");
        }
    }
}
