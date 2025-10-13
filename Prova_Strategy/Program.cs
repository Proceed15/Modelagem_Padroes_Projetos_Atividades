// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class Program
{
    static void Main()
    {
        CalculadoraDeImpostos Calculo = new CalculadoraDeImpostos();
        Console.WriteLine("Calculadora de Impostos: ");
        Calculo.Calcular(1000.0, "ICMS");
        Calculo.Calcular(1000.0, "IPI");
        Calculo.Calcular(1000.0, "ISS");
        Console.WriteLine("\nSeção de Cálculos Concluída!");
        
    }
}
