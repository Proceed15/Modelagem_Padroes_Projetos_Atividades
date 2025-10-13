public class NumeroEsquerda : ImpressoraVisitor
{
    public double Valor { get; }
    public NumeroEsquerda(double valor)
    {
        Valor = valor;
    }
        
    public void Aceitar(IVisitor visitar)
    {
        visitar.Visitar(this);
    }
}