// Estratégia Concreta 3: Cálculo do ISS
public class ISS : IImposto
{
    public double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.05; // Alíquota de 5%
    }
}
