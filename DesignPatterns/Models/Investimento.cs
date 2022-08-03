using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class Investimento
    {
        public void Investir(ContaBancaria conta, IInvestimento tipoInvestimento)
        {
            double resultadoInvestimento = tipoInvestimento.Investir(conta.Saldo);
            conta.Depositar(resultadoInvestimento);
        }
    }
}
