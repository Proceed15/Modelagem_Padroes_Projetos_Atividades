// + VISITANTE CONCRETO JÁ IMPLEMENTADO +
// 6. Concrete Visitor 1: Calculador de Área
public class CalculadorAreaVisitor : IVisitorFigura
{
    public double AreaTotal { get; private set; }

    public void Visitar(Circulo circulo)
    {
        double area = Math.PI * circulo.Raio * circulo.Raio;
        Console.WriteLine($"Calculando área do Círculo de raio {circulo.Raio}: {area:F2}");
        AreaTotal += area;
    }

    public void Visitar(Quadrado quadrado)
    {
        double area = quadrado.Lado * quadrado.Lado;
        Console.WriteLine($"Calculando área do Quadrado de lado {quadrado.Lado}: {area:F2}");
        AreaTotal += area;
    }

    public void Visitar(Retangulo retangulo)
    {
        double area = retangulo.Largura * retangulo.Altura;
        Console.WriteLine($"Calculando área do Retângulo {retangulo.Largura}x{retangulo.Altura}: {area:F2}");
        AreaTotal += area;
    }
}