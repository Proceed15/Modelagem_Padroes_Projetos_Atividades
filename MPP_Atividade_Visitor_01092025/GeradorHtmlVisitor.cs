using System;
using System.Collections.Generic;
using System.Text;

public class GeradorHtmlVisitor : IVisitor
{
    private StringBuilder _html = new StringBuilder();

    public string GetHtml()
    {
        return _html.ToString();
    }

    public void Visit(Titulo t)
    {
        _html.Append($"\n<h{t.Nivel}>{t.Texto}</h{t.Nivel}>\n");
    }

    public void Visit(Paragrafo p)
    {
        _html.Append($"<p>{p.Texto}</p>");
    }

    public void Visit(Imagem i)
    {
        _html.Append($"\n<img src=\"{i.Path}\" alt=\"{i.Caption}\" />\n");
    }

    public void Visit(Tabela tbl)
    {
        _html.Append("\n<table>");
        foreach (var linha in tbl.Dados)
        {
            _html.Append("<tr>");
            foreach (var celula in linha)
            {
                _html.Append($"<td>{celula}</td>");
            }
            _html.Append("</tr>");
        }
        _html.Append("</table>\n");
    }
}