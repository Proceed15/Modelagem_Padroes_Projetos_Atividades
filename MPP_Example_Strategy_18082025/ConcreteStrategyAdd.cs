// 2. As Estratégias Concretas (Concrete Strategies)
// Implementam o algoritmo seguindo a interface da estratégia.

// Estratégia para Adição
public class ConcreteStrategyAdd : IStrategy
{
    public int Execute(int a, int b)
    {
        Console.WriteLine("Executando a Estratégia de Soma: ");
        return a + b;
    }
}