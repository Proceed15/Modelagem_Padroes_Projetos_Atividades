
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Quadrado quadrado = new Quadrado(66);
        Triangulo triangulo = new Triangulo(4, 6);
        HexagonoEstrangeiro hexagonoEstrangeiro = new HexagonoEstrangeiro(9);
        AdaptadorHexagono adaptadorHexagono = new AdaptadorHexagono();
        adaptadorHexagono.setHexagonoEstrangeiro(hexagonoEstrangeiro);

        List<Poligono> poligonos = new List<Poligono>
        {
            quadrado,
            triangulo,
            adaptadorHexagono // Chamando o Adapter 
        };

        //Um para cada da Lista
        foreach (var poligono in poligonos)
        {
            Console.WriteLine($"{poligono.getName()}");
            Console.WriteLine($"Área: {poligono.getArea()}\n");
        }
    }
}
