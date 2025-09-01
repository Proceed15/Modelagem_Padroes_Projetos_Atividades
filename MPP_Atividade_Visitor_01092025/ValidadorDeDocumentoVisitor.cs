using System;
using System.Collections.Generic;

public class ValidadorDeDocumentoVisitor : IVisitor
{
    private List<string> _erros = new List<string>();
    private IElemementoDocumento _ultimoElemento = null;
    private bool _temTituloNivel1 = false;
    private int _indice = 0;

    public List<string> GetErros() => _erros;

    public bool IsValido() => !_erros.Any();

    public void Visit(Titulo t)
    {
        if (_indice == 0 && t.Nivel != 1)
        {
            _erros.Add("Regra 1: Todo documento deve começar com um Título de nível 1.");
        }

        _ultimoElemento = t;
        _indice++;
    }

    public void Visit(Paragrafo p)
    {
        var palavras = p.Texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (palavras.Length > 200)
        {
            _erros.Add("Regra 3: O texto de um parágrafo não deve exceder 200 palavras.");
        }

        _ultimoElemento = p;
        _indice++;
    }

    public void Visit(Imagem i)
    {
        if (_ultimoElemento is Imagem)
        {
            _erros.Add("Regra 2: Uma imagem não pode vir imediatamente após a outra sem um parágrafo ou título entre elas.");
        }

        _ultimoElemento = i;
        _indice++;
    }

    public void Visit(Tabela tbl)
    {
        _ultimoElemento = tbl;
        _indice++;
    }
}