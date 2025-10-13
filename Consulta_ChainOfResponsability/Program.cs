// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

public class Program
{
    public static void Main(string[] args)
    {
        CalculadoraDeDescontos calculadora = new CalculadoraDeDescontos();

        Console.WriteLine("\n--- Padrão Chain of Responsibility ---");

        // Teste 1: Deve ser pego pelo primeiro elo (DescontoPorValorAlto)
        Console.WriteLine("\nTestando orçamento de R$ 1500...");
        Orcamento orcamentoAlto = new Orcamento(1500);
        double desconto1 = calculadora.Calcula(orcamentoAlto);
        Console.WriteLine($"Desconto final: {desconto1:C}");

        // Teste 2: Deve passar pelo primeiro e ser pego pelo segundo (DescontoPorValorMedio)
        Console.WriteLine("\nTestando orçamento de R$ 700...");
        Orcamento orcamentoMedio = new Orcamento(700);
        double desconto2 = calculadora.Calcula(orcamentoMedio);
        Console.WriteLine($"Desconto final: {desconto2:C}");

        // Teste 3: Deve passar por todos e cair no último (SemDesconto)
        Console.WriteLine("\nTestando orçamento de R$ 300...");
        Orcamento orcamentoBaixo = new Orcamento(300);
        double desconto3 = calculadora.Calcula(orcamentoBaixo);
        Console.WriteLine($"Desconto final: {desconto3:C}");
    }
}