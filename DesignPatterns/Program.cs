using DesignPatterns.Interfaces;
using DesignPatterns.Models;
using DesignPatterns.Models.Investimentos;
using DesignPatterns.Models.Impostos;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Curso de Design Patterns");
Console.WriteLine("");

ExemploImposto();
ExemploInvestimento();

Console.WriteLine(@"Tecle ""Enter"" para finalizar a aplicação...");
Console.ReadKey();

static void ExemploImposto()
{
    Console.WriteLine("Strategy - exemplo imposto...");

    IImposto icms = new ICMS();
    IImposto iss = new ISS();
    IImposto iccc = new ICCC();

    var orcamento = new Orcamento(7400.0);

    var calculadora = new CalculadoraDeImpostos();
    calculadora.RealizarCalculo(orcamento, icms);
    calculadora.RealizarCalculo(orcamento, iss);
    calculadora.RealizarCalculo(orcamento, iccc);
}

static void ExemploInvestimento()
{
    Console.WriteLine("Strategy - exemplo investimento...");

    var conta = new ContaBancaria();
    conta.Depositar(1000);
    conta.VisualizarSaldo();

    IInvestimento conservador = new Conservador();
    IInvestimento moderado = new Moderado();
    IInvestimento ousado = new Arrojado();

    var investimento = new Investimento();
    investimento.Investir(conta, conservador);
    conta.VisualizarSaldo();
    investimento.Investir(conta, moderado);
    conta.VisualizarSaldo();
    investimento.Investir(conta, ousado);
    conta.VisualizarSaldo();

}