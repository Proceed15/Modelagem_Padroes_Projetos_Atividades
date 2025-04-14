// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Microsoft.VisualBasic;
/*
class Program {
    //Console.WriteLine("Digite o Lado");
    static void Main(string[] args){
        /*
        var cliente = new Quadrado();
        var cliente2 = new AdaptadorHexagono();
        var cliente3 = new Triangulo();
        */
        /*
        Poligono Quadrado = new Quadrado(65);
        Poligono Triangulo = new Triangulo(4, 6);

        List<Poligono> poligonos = new List<Poligono>{
        

        };
    }
}
*/
using System;
using System.Collections.Generic;
/*
class Program
{
    static void Main()
    {
        // Create instances of different polygons
        Quadrado quadrado = new Quadrado(65);
        Triangulo triangulo = new Triangulo(4, 6);
        HexagonoEstrangeiro hexagonoEstrangeiro = new HexagonoEstrangeiro(6);
        AdaptadorHexagono adaptadorHexagono = new AdaptadorHexagono(hexagonoEstrangeiro);

        // Create a list of Poligonos (polygons)
        List<Poligono> poligonos = new List<Poligono>
        {
            quadrado,
            triangulo,
            adaptadorHexagono // Using the adapter for the hexagon
        };

        // Iterate through each polygon and print its area
        foreach (var poligono in poligonos)
        {
            Console.WriteLine($"Área: {poligono.getArea()}");
        }
    }
}
*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create instances of different polygons
        Quadrado quadrado = new Quadrado(5);
        Triangulo triangulo = new Triangulo(4, 6);

        // Create a HexagonoEstrangeiro instance and wrap it using AdaptadorHexagono
        HexagonoEstrangeiro hexagonoEstrangeiro = new HexagonoEstrangeiro(6);
        AdaptadorHexagono adaptadorHexagono = new AdaptadorHexagono();
        adaptadorHexagono.setHexagonoEstrangeiro(hexagonoEstrangeiro);  // Setting the HexagonoEstrangeiro instance in the adapter

        // Create a list of Poligonos (polygons)
        List<Poligono> poligonos = new List<Poligono>
        {
            quadrado,
            triangulo,
            adaptadorHexagono // Using the adapter for the hexagon
        };

        // Iterate through each polygon and print its area
        foreach (var poligono in poligonos)
        {
            Console.WriteLine($"Área: {poligono.getArea()}");
        }
    }
}
