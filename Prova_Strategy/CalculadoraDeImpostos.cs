public class CalculadoraDeImpostos
{
    private IImposto strategy = null!;

    public void SetStrategy(IImposto strategy)
    {
        this.strategy = strategy;
    }
    public void Calcular(double ValorTotal, string Tipo)
    {
        if (Tipo.Equals("ICMS", StringComparison.OrdinalIgnoreCase))
        {
            SetStrategy(new ICMS());
        }
        else if (Tipo.Equals("ISS", StringComparison.OrdinalIgnoreCase))
        {
            SetStrategy(new ISS());
        }
        else if (Tipo.Equals("IPI", StringComparison.OrdinalIgnoreCase))
        {
            SetStrategy(new IPI());
        }
        else
        {
            Console.WriteLine("Tipo de imposto inválido.");
            return;
        }
        double ImpostoCalculado = strategy.CalcularImposto(ValorTotal);
        Console.WriteLine($"Valor Total: R$ {ValorTotal:F2} - Imposto ({Tipo}): R$ {ImpostoCalculado:F2}");
    }
}