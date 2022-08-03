using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.Impostos
{
    public class ISS : IImposto
    {
        private const double PORCENTAGEM = 0.06;

        public double Calcular(Orcamento orcamento) => orcamento.Valor * PORCENTAGEM;
    }
}
