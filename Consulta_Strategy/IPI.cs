// Estratégia Concreta 2: Cálculo do IPI
public class IPI : IImposto
{
    public double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.15; // Alíquota de 15%
    }
}

