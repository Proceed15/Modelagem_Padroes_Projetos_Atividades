// 4. Concrete Element B: Quadrado
public class Quadrado : IFiguraGeometrica
{
    public double Lado { get; }

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public void Aceitar(IVisitorFigura visitor)
    {
        visitor.Visitar(this);
    }
}