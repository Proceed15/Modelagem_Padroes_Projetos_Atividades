using System;

public class ContadorDePalavrasVisitor : IVisitor
{
    private int _totalPalavras = 0;

    public int GetTotalPalavras()
    {
        return _totalPalavras;
    }

    public void Visit(Titulo t)
    {
        _totalPalavras += t.Texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public void Visit(Paragrafo p)
    {
        _totalPalavras += p.Texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public void Visit(Imagem i)
    {
        //Eu deixei nada escrito aqui para fazer com que ele ignore imagens e para deixar ele diferente dos outros
    }

    public void Visit(Tabela tbl)
    {
        foreach (var linha in tbl.Dados)
        {
            foreach (var celula in linha)
            {
                _totalPalavras += celula.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            }
        }
    }
}