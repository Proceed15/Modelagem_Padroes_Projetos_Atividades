// --- ELEMENTO CONCRETO 3: Subtracao ---
public class Subtracao : IExpressao
{
    public IExpressao Esquerda { get; private set; }
    public IExpressao Direita { get; private set; }

    public Subtracao(IExpressao esquerda, IExpressao direita)
    {
        Esquerda = esquerda;
        Direita = direita;
    }

    public void Aceita(IVisitor visitor)
    {
        visitor.VisitaSubtracao(this);
    }
}