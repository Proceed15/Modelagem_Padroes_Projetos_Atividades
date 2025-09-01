// + VISITANTE CONCRETO IMPLEMENTADO PARA O DESAFIO
// 8. Concrete Visitor 2: Getter de Informações das Figuras
public class ViewVisitor : IVisitorFigura
{
    public double Visualizar { get; private set; }
    public double Visualizar1 { get; private set; }
    public double Visualizar2 { get; private set; }

    public void Visitar(Circulo circulo)
    {
        double Raios = circulo.Raio;
        Console.WriteLine($"Raio do Círculo: {Raios:F2}");
        Visualizar += Raios;
    }
    public void Visitar(Quadrado quadrado)
    {
        double Lados = quadrado.Lado;
        Console.WriteLine($"Lados do Quadrado: {Lados:F2}");
        Visualizar1 += Lados;
    }
    public void Visitar(Retangulo retangulo)
    {
        double Larguras = retangulo.Largura;
        double Alturas = retangulo.Altura;
        double AreaA = Larguras * Alturas;
        Console.WriteLine($"Altura do Retângulo: {Alturas}, Largura do Retângulo: {Larguras} e Área do Retângulo: {AreaA:F2}");
        Visualizar2 += AreaA;
    }/*
    public void Visitar(Retangulo retangulo)
    {
        double Larguras = retangulo.Largura;
        double Alturas = retangulo.Altura;
        double AreaA = Larguras * Alturas;
        //Array AreaB = [Alturas, Larguras, AreaA]; 
        Console.WriteLine($"Altura do Retângulo: {Alturas}, Largura do Retângulo: {Larguras} e Área do Retângulo: {AreaA:F2}");
        Visualizar2 += AreaA;
    }
    */  
} 