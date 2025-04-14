using System.Runtime.InteropServices;
using System;
using Microsoft.VisualBasic;
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
