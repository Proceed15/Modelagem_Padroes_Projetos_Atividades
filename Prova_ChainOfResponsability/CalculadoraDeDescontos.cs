public abstract class CalculadoraDeDescontos : IDesconto
{
    private IDesconto? _proximo;
    public void DefineProximo(IDesconto proximo)
    {
        _proximo = proximo;
    }
    public virtual void AprovaDesconto(SolicitaDesconto solicita)
    {
        _proximo?.AprovaDesconto(solicita);
    }
}
