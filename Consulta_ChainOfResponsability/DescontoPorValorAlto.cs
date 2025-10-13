// --- HANDLER CONCRETO 1 ---
// Responsável pela regra de desconto para valores altos.
public class DescontoPorValorAlto : IDesconto
{
    public IDesconto Proximo { get; set; }

    public double Desconta(Orcamento orcamento)
    {
        // Verifica se PODE tratar esta requisição.
        if (orcamento.Valor > 1000)
        {
            Console.WriteLine("Aplicando desconto por valor ALTO (15%).");
            return orcamento.Valor * 0.15;
        }

        // Se não pode tratar, passa a responsabilidade para o próximo da corrente.
        Console.WriteLine("Valor não é alto, passando para o próximo da corrente...");
        return Proximo.Desconta(orcamento);
    }
}
