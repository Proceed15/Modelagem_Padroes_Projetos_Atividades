// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

// + ESTRUTURA DO PADRÃO VISITOR +
// + INTERFACE
// 1. Interface Element (Elemento)
// 2. Interface Visitor (Visitante)
// + ELEMENTOS CONCRETOS +
// 3. Concrete Element A: Circulo
// 4. Concrete Element B: Quadrado
// 5. Concrete Element C: Retangulo
// + VISITANTE CONCRETO JÁ IMPLEMENTADO +
// 6. Concrete Visitor 1: Calculador de Área
// + CÓDIGO CLIENTE +
// 7. Estrutura de Objetos e Execução
public class Program
{
    public static void Main(string[] args)
    {
        // Nossa estrutura de objetos (uma "tela" com várias figuras)
        var figuras = new List<IFiguraGeometrica>
        {
            new Circulo(10),
            new Quadrado(16),
            new Retangulo(8, 20)
        };
        Console.WriteLine("+ Mostrando os valores de todas as Figuras: +");
        var VisualizarVisitor = new ViewVisitor();
        foreach (var figura in figuras)
        {
            figura.Aceitar(VisualizarVisitor);
        }
        Console.WriteLine($"\nRaio do Círculo: {VisualizarVisitor.Visualizar:F2}");
        Console.WriteLine($"\nLado do Quadrado: {VisualizarVisitor.Visualizar1:F2}");
        Console.WriteLine($"\nÁrea do Retangulo: {VisualizarVisitor.Visualizar2:F2}");
        //Console.WriteLine($"\nÁrea do Retangulo: {VisualizarVisitor.Visualizar3:F2}");
        //Console.WriteLine($"\nÁrea do Retangulo: {VisualizarVisitor.Visualizar4:F2}");
        Console.WriteLine("\n==============================================\n");
        Console.WriteLine("+ Executando o Visitor de Cálculo de Área +");
        var areaVisitor = new CalculadorAreaVisitor();
        foreach (var figura in figuras)
        {
            figura.Aceitar(areaVisitor);
        }
        Console.WriteLine($"\nÁrea Total de todas as figuras: {areaVisitor.AreaTotal:F2}");
        Console.WriteLine("\n==============================================\n");
    }
}