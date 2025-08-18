public class ClassConteudo
{
    private InterfaceComissao strategy = null!;

    public void SetStrategy(InterfaceComissao strategy)
    {
        this.strategy = strategy;
    }

    public void ExecutaCalculo(double valorTotal, string categoria)
    {
        if (categoria.Equals("Especial", StringComparison.OrdinalIgnoreCase))
        {
            SetStrategy(new ClassComissaoConjunta());
        }
        else
        {
            SetStrategy(new ClassComissaoIndividual());
        }
        double comissaoVendedor = strategy.CalcularComissao(valorTotal);
        double comissaoSetor = valorTotal * 0.025;
        Console.WriteLine($"Valor Total: R$ {valorTotal:F2}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine($"Comissão do Vendedor: R$ {comissaoVendedor:F2}");

        if (categoria.Equals("Especial", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Comissão do Setor Comercial: R$ {comissaoSetor:F2}");
        }

        Console.WriteLine("------------------------");
    }
}