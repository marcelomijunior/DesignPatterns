using DesignPatterns.Interfaces;
using DesignPatterns.Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Curso de Design Patterns");
Console.WriteLine("");

IImposto icms = new ICMS();
IImposto iss = new ISS();
IImposto iccc = new ICCC();

var orcamento = new Orcamento(7400.0);

var calculadora = new CalculadoraDeImpostos();
calculadora.RealizarCalculo(orcamento, icms);
calculadora.RealizarCalculo(orcamento, iss);
calculadora.RealizarCalculo(orcamento, iccc);

Console.WriteLine(@"Tecle ""Enter"" para finalizar a aplicação...");
Console.ReadKey();
