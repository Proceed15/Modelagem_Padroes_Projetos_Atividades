// Estratégia para Subtração
public class ConcreteStrategySubtract : IStrategy
{
    public int Execute(int a, int b)
    {
        Console.WriteLine("Executando a Estratégia de Subtração: ");
        return a - b;
    }
}