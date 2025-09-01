// + INTERFACE +
// 1. Interface Element (Elemento)
// Define o método `Aceitar`, permitindo que um Visitor opere na figura.
public interface IFiguraGeometrica
{
    void Aceitar(IVisitorFigura visitor);
    //void Encontrar(IVisualizarVisitarFigura visualizar);
}


