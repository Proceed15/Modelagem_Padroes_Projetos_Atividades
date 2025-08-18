// Estratégia para Subtração
public class ConcreteStrategySubtract : IStrategy
{
    public int Execute(int a, int b)
    {
        Console.WriteLine("Executando a estratégia de SUBTRAÇÃO.");
        return a - b;
    }
}