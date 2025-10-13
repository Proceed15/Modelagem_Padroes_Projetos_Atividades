// --- HANDLER CONCRETO 2 ---
// Responsável pela regra de desconto para valores médios.
public class DescontoPorValorMedio : IDesconto
{
    public IDesconto Proximo { get; set; }

    public double Desconta(Orcamento orcamento)
    {
        if (orcamento.Valor > 500)
        {
            Console.WriteLine("Aplicando desconto por valor MÉDIO (10%).");
            return orcamento.Valor * 0.10;
        }

        Console.WriteLine("Valor não é médio, passando para o próximo da corrente...");
        return Proximo.Desconta(orcamento);
    }

    
}
