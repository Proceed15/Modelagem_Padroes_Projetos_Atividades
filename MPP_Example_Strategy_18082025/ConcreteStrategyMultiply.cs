// Estratégia para Multiplicação
public class ConcreteStrategyMultiply : IStrategy
{
    public int Execute(int a, int b)
    {
        Console.WriteLine("Executando a estratégia de MULTIPLICAÇÃO.");
        return a * b;
    }
}