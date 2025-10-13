// Esta classe utiliza uma estratégia de imposto.
// Ela não sabe qual é o imposto, apenas que ele sabe se "calcular".
public class CalculadoraDeImpostos
{
    public double RealizaCalculo(Orcamento orcamento, IImposto imposto)
    {
        // Delega a responsabilidade do cálculo para o objeto da estratégia recebido.
        double valorDoImposto = imposto.Calcula(orcamento);
        return valorDoImposto;
    }
}