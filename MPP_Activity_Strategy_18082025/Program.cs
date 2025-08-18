// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main()
    {
        ClassConteudo conteudo = new ClassConteudo();
        Console.WriteLine("Calculadora de Comissões: ");
        Console.WriteLine("------------------------");
        conteudo.ExecutaCalculo(1000.0, "Normal");

        conteudo.ExecutaCalculo(1500.0, "Especial");
    }
}