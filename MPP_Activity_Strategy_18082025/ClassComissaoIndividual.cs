public class ClassComissaoIndividual : InterfaceComissao
{
    public double CalcularComissao(double valorTotal)
    {
        return valorTotal * 0.050;
    }
}