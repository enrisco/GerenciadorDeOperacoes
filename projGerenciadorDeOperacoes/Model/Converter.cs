using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projGerenciadorDeOperacoes.Model
{
    class Converter
    {
        public Coin First, Destination;

        public double UnityConverter(double unidade)
        {
            double real = unidade * First.Value;
            return real / Destination.Value;
        }
    }
}
