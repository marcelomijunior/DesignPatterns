using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class ICMS : IImposto
    {
        private const double PORCENTAGEM = 0.05;

        public double Calcular(Orcamento orcamento) => orcamento.Valor * PORCENTAGEM;
    }
}
