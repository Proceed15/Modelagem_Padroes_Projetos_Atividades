using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Quadrado quadrado = new Quadrado(94);
        Triangulo triangulo = new Triangulo(4, 6);
        //Valor para a área de um Hexágono
        HexagonoEstrangeiro hexagonoEstrangeiro = new HexagonoEstrangeiro(88);
        AdaptadorHexagono adaptadorHexagono = new AdaptadorHexagono();
        //Chamando a Função do Adapter que pega o valor do CalculaArea e passa para o GetArea
        adaptadorHexagono.setHexagonoEstrangeiro(hexagonoEstrangeiro);

        List<Poligono> poligonos = new List<Poligono>
        {
            quadrado,
            triangulo,
            adaptadorHexagono // Chamando o Adapter que tem os métodos getArea e getName que podem ser convertidos na função poligono
        };

        //Um para cada membro da Lista
        foreach (var poligono in poligonos)
        {
            Console.WriteLine($"{poligono.getName()}");
            Console.WriteLine($"Área: {poligono.getArea()}\n");
        }
    }
}
