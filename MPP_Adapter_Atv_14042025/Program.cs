
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Quadrado quadrado = new Quadrado(5);
        Triangulo triangulo = new Triangulo(4, 6);
        HexagonoEstrangeiro hexagonoEstrangeiro = new HexagonoEstrangeiro(6);
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
            Console.WriteLine($"Área: {poligono.getArea()}");
        }
    }
}
