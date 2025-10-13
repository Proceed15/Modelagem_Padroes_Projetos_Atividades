public class Multiplicacao : IExpressao
{
    public double NumeroEsquerda { get; set; }
    public double NumeroDireita { get; set; }

    public Multiplicacao(double numeroEsquerda, double numeroDireita)
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

    public void Visitar(Multiplicacao multiplicacao)
    {
        Console.WriteLine($"Multiplicação: {multiplicacao.NumeroEsquerda} * {multiplicacao.NumeroDireita} = {multiplicacao.NumeroEsquerda * multiplicacao.NumeroDireita}");
    }
    void IExpressao.Visitar(Soma soma)
    {
        throw new NotImplementedException();
    }
    void IExpressao.Visitar(Subtracao subtracao)
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

    public void Visitar(Subtracao subtracao)
    {
        throw new NotImplementedException();
    }

    public void Visitar(Divisao divisao)
    {
        throw new NotImplementedException();
    }
}