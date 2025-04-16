public class Quadrado : Poligono
{
    public double Lado { get; set; }

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override double getArea()
    {
        return Lado * Lado;
    }
    public override string getName()
    {
        return "Quadrado";
    }
}
