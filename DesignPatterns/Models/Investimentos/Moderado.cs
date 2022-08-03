using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.Investimentos
{
    public class Moderado : IInvestimento
    {
        private const double PORCENTAGEM_IMPOSTO = 0.25;

        public double Investir(double valor)
        {
            int chance = new Random().Next(101);
            double resultadoInvestimento = chance >= 50 ? valor * 0.025 : valor * 0.007;
            double totalReceber = resultadoInvestimento - resultadoInvestimento * PORCENTAGEM_IMPOSTO;
            
            return totalReceber;
        }
    }
}
