using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.Impostos
{
    public class ICCC : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            double total = 0;

            if (orcamento.Valor <= 1000) total = orcamento.Valor * 0.05;
            else if (orcamento.Valor > 1000 && orcamento.Valor <= 3000) total = orcamento.Valor * 0.07;
            else if (orcamento.Valor > 3000) total = orcamento.Valor * 0.08 + 30.0;

            return total;
        }
    }
}
