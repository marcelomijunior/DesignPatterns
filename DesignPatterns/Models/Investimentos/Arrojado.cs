using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.Investimentos
{
    public class Arrojado : IInvestimento
    {
        private const double PORCENTAGEM_IMPOSTO = 0.25;
        
        public double Investir(double valor)
        {
            int chance = new Random().Next(101);
            double resultadoInvestimento = 0d;
            
            if (chance <= 20) resultadoInvestimento = valor * 0.050;
            else if (chance > 20 && chance < 50) resultadoInvestimento = valor * 0.030;
            else if (chance >= 50) resultadoInvestimento = valor * 0.006;

            double totalReceber = resultadoInvestimento - resultadoInvestimento * PORCENTAGEM_IMPOSTO;

            return totalReceber;
        }
    }
}
