// Estratégia para Multiplicação
public class ConcreteStrategyMultiply : IStrategy
{
    public int Execute(int a, int b)
    {
        Console.WriteLine("Executando a Estratégia de Multiplicação: ");
        return a * b;
    }
}