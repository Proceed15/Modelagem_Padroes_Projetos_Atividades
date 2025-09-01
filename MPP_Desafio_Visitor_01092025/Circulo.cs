// + ELEMENTOS CONCRETOS +
// 3. Concrete Element A: Circulo
public class Circulo : IFiguraGeometrica
{
    public double Raio { get; }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public void Aceitar(IVisitorFigura visitor)
    {
        visitor.Visitar(this);
    }/*
    public void Encontrar(IVisualizarVisitarFigura visualizar)
    {
        visualizar.Visualizar(this);
    }*/
}