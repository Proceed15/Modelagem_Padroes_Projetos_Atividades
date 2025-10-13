public class Divisao : IExpressao
{
    public double NumeroEsquerda { get; set; }
    public double NumeroDireita { get; set; }

    public Divisao(double numeroEsquerda, double numeroDireita)
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

    public void Visitar(Divisao divisao)
    {
        if (divisao.NumeroDireita != 0)
        {
            Console.WriteLine($"Divisão: {divisao.NumeroEsquerda} / {divisao.NumeroDireita} = {divisao.NumeroEsquerda / divisao.NumeroDireita}");
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
        }
    }
    void IExpressao.Visitar(Soma soma)
    {
        throw new NotImplementedException();
    }
    void IExpressao.Visitar(Multiplicacao multiplicacao)
    {
        throw new NotImplementedException();
    }
    void IExpressao.Visitar(Subtracao subtracao)
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

    public void Visitar(Subtracao subtracao)
    {
        throw new NotImplementedException();
    }
}