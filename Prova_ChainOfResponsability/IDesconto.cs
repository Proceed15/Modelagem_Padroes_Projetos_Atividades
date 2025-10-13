public interface IDesconto
{
    void DefineProximo(IDesconto proximo);
    void AprovaDesconto(SolicitaDesconto solicita);
}