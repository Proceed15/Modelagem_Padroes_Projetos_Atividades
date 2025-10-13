public class Soma : IExpressao
{
    public double NumeroEsquerda { get; set; }
    public double NumeroDireita { get; set; }

    public Soma(double numeroEsquerda, double numeroDireita)
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

    public void Visitar(Soma soma)
    {
        Console.WriteLine($"Soma: {soma.NumeroEsquerda} + {soma.NumeroDireita} = {soma.NumeroEsquerda + soma.NumeroDireita}");
    }
    void IExpressao.Visitar(Multiplicacao multiplicacao)
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

    public void Visitar(Multiplicacao multiplicacao)
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
