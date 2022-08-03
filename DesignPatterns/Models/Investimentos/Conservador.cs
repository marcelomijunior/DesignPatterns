using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.Investimentos
{
    public class Conservador : IInvestimento
    {
        private const double PORCENTAGEM_IMPOSTO = 0.25;

        public double Investir(double valor)
        {
            double resultadoInvestimento = valor * 0.008;
            double totalReceber = resultadoInvestimento - resultadoInvestimento * PORCENTAGEM_IMPOSTO;

            return totalReceber;
        }
    }
}
