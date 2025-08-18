public class ClassComissaoConjunta : InterfaceComissao
{
    public double CalcularComissao(double valorTotal)
    {
        return valorTotal * 0.025;
    }
}