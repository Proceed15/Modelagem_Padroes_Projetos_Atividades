using System;

public class ImpressoraVisitor : IVisitor
{
    public void Visitar(NumeroEsquerda numeroEsquerda)
    {
        numeroEsquerda.Aceitar(this);
    }

    public void Visitar(NumeroDireita numeroDireita)
    {
        numeroDireita.Aceitar(this);
    }

    public void Visitar(Soma soma)
    {
        Console.Write("(");
        //soma.NumeroEsquerda.Aceitar(this);

        Console.Write(" + ");
        //soma.NumeroDireita.Aceitar(this);
        Console.Write(")");
    }

    public void Visitar(Multiplicacao multiplicacao)
    {
        Console.Write("(");
        //multiplicacao.NumeroEsquerda.Aceitar(this);
        Console.Write(" * ");
        //multiplicacao.NumeroDireita.Aceitar(this);
        Console.Write(")");
    }

    public void Visitar(Subtracao subtracao)
    {
        Console.Write("(");
        //subtracao.NumeroEsquerda.Aceitar(this);
        Console.Write(" - ");
        //subtracao.NumeroDireita.Aceitar(this);
        Console.Write(")");
    }

    public void Visitar(Divisao divisao)
    {
        Console.Write("(");
        //divisao.NumeroEsquerda.Aceitar(this);
        Console.Write(" / ");
        //divisao.NumeroDireita.Aceitar(this);
        Console.Write(")");
    }
}
