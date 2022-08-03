using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class ContaBancaria
    {
        private double saldo;
        public double Saldo => saldo;

        public ContaBancaria()
        {
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void VisualizarSaldo()
        {
            Console.WriteLine(saldo.ToString("C", new CultureInfo("pt-BR")));
        }
    }
}
