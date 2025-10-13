public class NumeroDireita : ImpressoraVisitor
{
    public double Valor { get; }
    public NumeroDireita(double valor)
    {
        Valor = valor;
    }

    public void Aceitar(IVisitor visitar)
    {
        visitar.Visitar(this);
    }
}