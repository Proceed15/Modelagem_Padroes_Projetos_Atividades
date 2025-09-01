// 2. Interface Visitor (Visitante)
// Declara um método `Visitar` para cada tipo de figura concreta.
public interface IVisitorFigura
{
    void Visitar(Circulo circulo);
    void Visitar(Quadrado quadrado);
    void Visitar(Retangulo retangulo);
}