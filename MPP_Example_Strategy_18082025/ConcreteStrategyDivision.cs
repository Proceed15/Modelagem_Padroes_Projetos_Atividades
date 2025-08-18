// Estratégia para Divisão
public class ConcretestrategyDivision : IStrategy
{
    public int Execute(int a, int b)
    {
        Console.WriteLine("Executando a Estratégia de Divisão: ");
        return a / b;
    }
} 