// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // 1. Criamos as diferentes estratégias de cálculo
        IImposto icms = new ICMS();
        IImposto ipi = new IPI();
        IImposto iss = new ISS();

        // 2. Criamos o orçamento
        Orcamento orcamento = new Orcamento(1000.0);

        // 3. Criamos a calculadora
        CalculadoraDeImpostos calculadora = new CalculadoraDeImpostos();

        // 4. Usamos a calculadora com as diferentes estratégias
        double valorIcms = calculadora.RealizaCalculo(orcamento, icms);
        double valorIpi = calculadora.RealizaCalculo(orcamento, ipi);
        double valorIss = calculadora.RealizaCalculo(orcamento, iss);

        Console.WriteLine("--- Padrão Strategy ---");
        Console.WriteLine($"Valor do ICMS: {valorIcms:C}"); // Ex: R$ 100,00
        Console.WriteLine($"Valor do IPI: {valorIpi:C}");   // Ex: R$ 150,00
        Console.WriteLine($"Valor do ISS: {valorIss:C}");   // Ex: R$ 50,00
    }
}