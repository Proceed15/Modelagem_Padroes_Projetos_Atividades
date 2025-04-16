public class Triangulo : Poligono
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double baseTriangulo, double altura)
    {
        Base = baseTriangulo;
        Altura = altura;
    }

    public override double getArea()
    {
        return (Base * Altura) / 2;
    }
    public override string getName()
    {
        return "Triângulo";
    }
}
