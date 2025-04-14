using System.Runtime.InteropServices;
using System;
using Microsoft.VisualBasic;
/*
class HexagonoEstrangeiro:Poligono{
    public static float ToSingle(double lado)
    {
        return(float) lado;
    }
    public float calculaArea()
    {
        float area = 3 * (lado * lado) * Math.Sqrt(3)/2;
        return area;
    }
}
*/
public class HexagonoEstrangeiro
{
    public double Lado { get; set; }

    public HexagonoEstrangeiro(double lado)
    {
        Lado = lado;
    }

    public double calculaArea()
    {
        return (3 * (Lado * Lado) * Math.Sqrt(3)) / 2;
    }
}
