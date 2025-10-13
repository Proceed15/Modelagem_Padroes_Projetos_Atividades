// Estratégia Concreta 1: Cálculo do ICMS
public class ICMS : IImposto
{
    public double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.1; // Alíquota de 10%
    }
}

