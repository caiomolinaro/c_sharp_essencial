﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_Indexadores
{
    public class Time
    {
        string[] valor = new string[10];

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < valor.Length)
                {
                    return valor[i];
                }
                return "Erro";
            }
            set
            {
                if (i >= 0 && i < valor.Length)
                {
                    valor[i] = value;
                }
            }
        }
    }
}
