// --- ELEMENTO CONCRETO 2: Soma ---
public class Soma : IExpressao
{
    public IExpressao Esquerda { get; private set; }
    public IExpressao Direita { get; private set; }

    public Soma(IExpressao esquerda, IExpressao direita)
    {
        Esquerda = esquerda;
        Direita = direita;
    }

    // O mesmo padrão: a Soma informa ao visitor que ele é uma Soma.
    public void Aceita(IVisitor visitor)
    {
        visitor.VisitaSoma(this);
    }
}



