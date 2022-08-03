using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class CalculadoraDeImpostos
    {
        public void RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            var novoValor = imposto.Calcular(orcamento);
            Console.WriteLine($"\nImposto: {imposto.GetType().Name}\nValor do imposto: {novoValor}");
        }
    }
}
