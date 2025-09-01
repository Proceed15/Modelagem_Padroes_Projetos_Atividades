// 5. Concrete Element C: Retangulo
public class Retangulo : IFiguraGeometrica
{
    public double Largura { get; }
    public double Altura { get; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public void Aceitar(IVisitorFigura visitor)
    {
        visitor.Visitar(this);
    }
}