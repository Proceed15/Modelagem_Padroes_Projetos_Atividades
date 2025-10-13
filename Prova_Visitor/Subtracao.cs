public class  Subtracao : IExpressao
{
    public double NumeroEsquerda { get; set; }
    public double NumeroDireita { get; set; }

    public Subtracao(double numeroEsquerda, double numeroDireita)
    {
        NumeroEsquerda = numeroEsquerda;
        NumeroDireita = numeroDireita;
    }

    public void Aceitar(IVisitor visitor)
    {
        visitor.Visitar(this);
    }

    public void Visitar(NumeroEsquerda numeroEsquerda)
    {
        throw new NotImplementedException();
    }

    public void Visitar(NumeroDireita numeroDireita)
    {
        throw new NotImplementedException();
    }

    public void Visitar(Subtracao subtracao)
    {
        Console.WriteLine($"Subtração: {subtracao.NumeroEsquerda} - {subtracao.NumeroDireita} = {subtracao.NumeroEsquerda - subtracao.NumeroDireita}");
    }
    void IExpressao.Visitar(Soma soma)
    {
        throw new NotImplementedException();
    }
    void IExpressao.Visitar(Multiplicacao multiplicacao)
    {
        throw new NotImplementedException();
    }
    void IExpressao.Visitar(Divisao divisao)
    {
        throw new NotImplementedException();
    }

    public void Visitar(Soma soma)
    {
        throw new NotImplementedException();
    }

    public void Visitar(Multiplicacao multiplicacao)
    {
        throw new NotImplementedException();
    }

    public void Visitar(Divisao divisao)
    {
        throw new NotImplementedException();
    }
}